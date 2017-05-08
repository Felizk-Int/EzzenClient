using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

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
        private ChatBox chatBox;

        public GroupMessenger(String groupID, String clientID, ChatBox chatBox)
        {
            this.groupID = groupID;
            this.clientID = clientID;
            this.chatBox = chatBox;
            chats = new List<Message>();
            buffer = new SortedList<uint, Message>();
            recvMessageThread = new Thread(removeTopBuffer);
            recvMessageThread.IsBackground = true;
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
            try
            {
                using (StreamReader sr = File.OpenText(cachePath))
                {
                    String msg;
                    while ((msg = sr.ReadLine()) != null)
                    {
                        feedMessage(Message.cacheStringToMessage(msg));
                    }
                    sr.Close();
                }
            }
            catch (FileNotFoundException) { }
            return lastMessageNo;
        }

        public void saveCache()
        {
            System.IO.File.Create(cachePath).Close();
            using (StreamWriter sw = File.CreateText(cachePath))
            {
                foreach (Message msg in chats)
                {
                    sw.WriteLine(msg.toCacheString());
                }
                sw.Close();
            }
        }

        public void feedMessage(Message message)
        {
            chats.Add(message);
            // Show message on screen
            string msg = "Client ID: " + message.clientID + " said (" + message.timestamp.ToString() +") :";
            chatBox.AppendText(msg);
            msg = "\n" + message.message + "\n";
            chatBox.AppendText(msg);
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
            while (true){
                lock (syncLock)
                {
                    if(buffer.Count != 0 && lastMessageNo + 1 == buffer.Keys[0])
                    {
                        feedMessage(buffer.Values[0]);
                        buffer.RemoveAt(0);
                    }
                }
            }
        }
    }

    public class Message
    {
        public const char Separator = ((char)007);

        private uint messageNo;
        public String clientID;
        public String message;
        public DateTime timestamp;

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
            return msg.Split(Separator);
        }
    }
}
