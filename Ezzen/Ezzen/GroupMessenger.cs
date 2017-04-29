using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;

namespace Ezzen
{
    public class GroupMessenger
    {
        private String groupID;
        private String clientID;
        private List<Message> chats;
        private String cachePath;
        private UInt32 lastMessageNo;
        private Thread recvMessageThread;
        private readonly object syncLock;

        private SortedList<uint, Message> buffer;

        public GroupMessenger(String groupID, String clientID)
        {
            this.groupID = groupID;
            this.clientID = clientID;
            chats = new List<Message>();
            buffer = new SortedList<uint, Message>();
            recvMessageThread = new Thread(removeTopBuffer);
            syncLock = new object();
            cachePath = "localcache\\" + clientID + "_" + groupID + ".txt";
            lastMessageNo = 0;
        }

        public void startThread()
        {
            recvMessageThread.Start();
        }

        public void abortThread()
        {
            recvMessageThread.Abort();
        }

        public UInt32 loadCache()
        {
            using (StreamReader sr = File.OpenText(cachePath))
            {
                String msg;
                while ((msg = sr.ReadLine()) != null)
                {
                    feedMessage(Message.cacheStringToMessage(msg));
                    lastMessageNo++;
                }
            }
            return lastMessageNo;
        }

        public void saveCache()
        {
            using (StreamWriter sw = File.CreateText(cachePath))
            {
                foreach (Message msg in chats)
                {
                    sw.WriteLine(msg.toCacheString());
                }
            }
        }

        public void feedMessage(Message message)
        {
            chats.Add(message);
            // Show message on screen
            lastMessageNo++;
        }

        public String getGroupID()
        {
            return groupID;
        }

        public UInt32 getLastMessageNo()
        {
            return lastMessageNo;
        }

        public void feedBuffer(Message message)
        {
            lock (syncLock)
            {
                buffer.Add(message.getMessageNo(), message);
            }
        }

        private void removeTopBuffer()
        {
            lock (syncLock)
            {
                if (buffer.Count != 0 && lastMessageNo + 1 == buffer.Keys[0])
                {
                    feedMessage(buffer.Values[0]);
                    buffer.RemoveAt(0);
                }
            }
        }
    }

    public class Message
    {
        public const char Separator = ' ';// ((char)007);

        private uint messageNo;
        private String clientID;
        private String message;
        private DateTime timestamp;

        public Message(uint messageNo, String clientID, String message, DateTime timestamp)
        {
            this.messageNo = messageNo;
            this.clientID = clientID;
            this.message = message;
            this.timestamp = timestamp;
        }

        public uint getMessageNo()
        {
            return messageNo;
        }

        public String toCacheString()
        {
            return messageNo.ToString() + Separator + clientID + Separator + message + Separator + timestamp.ToString();
        }

        public static Message cacheStringToMessage(String msg)
        {
            String[] msgs = msg.Split(Separator);
            return new Message(Convert.ToUInt32(msgs[0]), msgs[1], msgs[2], Convert.ToDateTime(msgs[3]));
        }

        public static String[] splitString(String msg)
        {
            Console.WriteLine("YOOHOO!, I'm here!");
            return msg.Split(Separator);
        }
    }
}
