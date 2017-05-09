using System;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Collections.Generic;

namespace Ezzen
{

    public class ClientSocket
    {

        private System.Net.Sockets.TcpClient clientSocket;
        private NetworkStream serverStream;
        private String clientID;
        private String cachePath;
        private Thread recvMessageThread;
        private readonly object syncLock;
        private readonly object streamLock;
        
        private Dictionary<String, GroupMessenger> groupChats;
        private Dictionary<String, bool> hasgroup;
        private bool backupServer;

        //getters & setters;
        public string ClientID { get => clientID; }
        public string something = "";

        public ClientSocket()
        {
            clientID = null;
            cachePath = null;
            groupChats = new Dictionary<string, GroupMessenger>();
            hasgroup = new Dictionary<string, bool>();
            recvMessageThread = new Thread(recvMessageAsyn);
            recvMessageThread.IsBackground = true;
            syncLock = new object();
            streamLock = new object();
            backupServer = false;
            connect("104.199.115.20", 8888);
        }

        public void connect(String ipaddress, int port)
        {
            clientSocket = new System.Net.Sockets.TcpClient();
            clientSocket.Connect(ipaddress, port);
            serverStream = clientSocket.GetStream();
            serverStream.ReadTimeout = 500;
            recvMessageThread.Start();
        }

        public void disconnect()
        {
            recvMessageThread.Abort();
            String msg = "C" + Message.Separator + "DISC" + Message.Separator + clientID;
            sendMsg(msg);
            clientSocket.Close();
        }

        public String signup(String username, String password)
        {
            String msg = "C" + Message.Separator + "SIGN" + Message.Separator + username + Message.Separator + password;
            lock (streamLock)
            {
                sendMsg(msg);
                msg = recvMessage();
            }
            String[] proc_msg = Message.splitString(msg);
            if (proc_msg[0] == "R")
            {
                if (proc_msg[1] == "SUCC") return "SIGNUP SUCCEED";
                else if (proc_msg[1] == "FAIL") return "SIGNUP FAIL";
            }
            return "ERROR";
        }

        public String login(String username, String password)
        {
            String msg = "C" + Message.Separator + "LOGN" + Message.Separator + username + Message.Separator + password;
            lock (streamLock)
            {
                sendMsg(msg);
                msg = recvMessage();
            }
            String[] proc_msg = Message.splitString(msg);
            if (proc_msg[0] == "R")
            {
                if (proc_msg[1] == "SUCC")
                {
                    clientID = proc_msg[2];
                    cachePath = "localcache\\" + clientID + ".txt";
                    loadCache();
                    return clientID;
                }
                else if (proc_msg[1] == "FAIL") return "LOGIN FAIL";
            }
            return "ERROR";
        }

        public void logout(){
            lock (syncLock){
                String msg = "C" + Message.Separator + "LOGO" + Message.Separator + clientID;
                sendMsg(msg);
                saveCache();
                clientID = null;
                cachePath = null;
            }
        }

        public void joinGroup(String groupID)
        {
            lock (syncLock)
            {
                String msg = "C" + Message.Separator + "JOIN" + Message.Separator + clientID + Message.Separator + groupID;
                sendMsg(msg);
                if (!groupChats.ContainsKey(groupID))
                {
                    //groupChats.Add(groupID, new GroupMessenger(groupID, clientID));
                    hasgroup.Add(groupID, false);
                    //groupChats[groupID].startThread();
                    //groupChats[groupID].loadCache();
                }
                
            }
            // Add group on screen
            if (hasgroup[groupID] == false)
            {
                hasgroup[groupID] = true;
                ChatGroup cg = new ChatGroup(groupID, groupID, clientID);
                Program.GroupList[groupID] = cg;
                Program.MW.MainWindow_Enter(new object(), new EventArgs());
            }
            loadUnread(groupID);
        }

        public void exitGroup(String groupID)
        {
            lock (syncLock)
            {
                String msg = "C" + Message.Separator + "EXTG" + Message.Separator + clientID + Message.Separator + groupID;
                sendMsg(msg);
                //groupChats[groupID].abortThread();
                //groupChats[groupID].saveCache();
                //groupChats.Remove(groupID);
            }
            // Remove group on screen and save to cache
            if (hasgroup[groupID])
            {
                hasgroup[groupID] = false;
                Program.GroupList.Remove(groupID);
                //foreach (ChatGroup g in Program.GroupList)
                //{
                //    if(g.GroupName == groupID)
                //    {
                        //g.getGroupMessenger().abortThread();
                        //g.getGroupMessenger.saveCache();
                //        Program.GroupList.Remove(g);
                //    }
                //}
            }
        }

        public void leaveGroup(String groupID)
        {
            lock (syncLock)
            {
                String msg = "C" + Message.Separator + "LEVG" + Message.Separator + clientID + Message.Separator + groupID;
                sendMsg(msg);
                //groupChats[groupID].abortThread();
                //groupChats.Remove(groupID);
            }
            // Remove group on screen
            if (hasgroup[groupID])
            {
               hasgroup[groupID] = false;
                Program.GroupList[groupID].getGroupMessenger().removeCache();
                Program.GroupList.Remove(groupID);
                //foreach (ChatGroup g in Program.GroupList)
              // {
               //     if (g.GroupName == groupID)
                 //   {
                  //      g.getGroupMessenger().abortThread();
                 //       Program.GroupList.Remove(g);
                 //   }
              //  }
            }
        }

        public void loadUnread(String groupID)
        {
            String msg = "C" + Message.Separator + "LUNR" + Message.Separator + clientID + Message.Separator + groupID + Message.Separator +  Program.GroupList[groupID].getGroupMessenger().getLastMessageNo();
            sendMsg(msg);
        }

        private void sendMsg(String msg)
        {
            lock (streamLock)
            {
              try
             {
                    byte[] outStream = System.Text.Encoding.ASCII.GetBytes(msg);
                    serverStream.Write(outStream, 0, outStream.Length);
                    serverStream.Flush();
                
              }
              catch (IOException)
              {
                   try{
                        recvMessageThread.Abort();
                        clientSocket.Close();
                        serverStream.Close();
                        if (!backupServer) { connect("104.199.115.20", 9999); backupServer = true; }
                        else { connect("104.199.115.20", 8888); backupServer = false; }
                        serverStream = clientSocket.GetStream();
                        serverStream.ReadTimeout = 500;
                        recvMessageThread.Start();
                        //Resend Message
                        byte[] outStream = System.Text.Encoding.ASCII.GetBytes(msg);
                        serverStream.Write(outStream, 0, outStream.Length);
                        serverStream.Flush();
                    }
                    catch (IOException){
                        //GG all server is down.
                    }
              }
            }
        }

        private String recvMessage()
        {
            lock (streamLock)
            {
                try{
                    byte[] inStream = new byte[512];
                    serverStream.Read(inStream, 0, 512);
                    return System.Text.Encoding.ASCII.GetString(inStream).Trim((char)000, '\n');
                }
                catch (IOException){

                }
            }
            return "";
        }
        
        private void recvMessageAsyn()
        {
            while (true)
            {
                String msg = recvMessage();
                String[] msgs = msg.Split('\n');
                foreach (String mess in msgs){
                    String[] proc_msg = Message.splitString(mess);
                    if (proc_msg[0] == "M")
                    {
                        Message tmp = new Message(Convert.ToUInt32(proc_msg[1]), proc_msg[2], proc_msg[4], Convert.ToDateTime(proc_msg[5]));
                        lock (syncLock)
                        {
                            if (Program.GroupList.ContainsKey(proc_msg[3])) Program.GroupList[proc_msg[3]].getGroupMessenger().feedBuffer(tmp);
                        }
                    }
                }
            }
        }

        private void loadCache()
        {
            try
            {
                using (StreamReader sr = File.OpenText(cachePath))
                {
                    String msg;
                    while ((msg = sr.ReadLine()) != null)
                    {
                        ChatGroup tmp = new ChatGroup(msg, msg, clientID);
                        tmp.getGroupMessenger().loadCache();
                        Program.GroupList.Add(msg, tmp);
                    }
                    Program.MW.MainWindow_Enter(new object(), new EventArgs());
                }
            }
            catch (FileNotFoundException) { }
        }

        private void saveCache()
        {
            System.IO.File.Create(cachePath).Close();
            using (StreamWriter sw = File.CreateText(cachePath))
            {
                foreach (var pair in Program.GroupList)
                {
                    sw.WriteLine(pair.Key);
                    pair.Value.getGroupMessenger().saveCache();
                }
                Program.GroupList.Clear();
            }
        }

        public void send(string groupid, string cid, string message, string time)
        {
            string msg = "M" + Message.Separator + groupid + Message.Separator + cid + Message.Separator + message + Message.Separator + time;
            sendMsg(msg);
            Console.WriteLine(msg);
        }
    }
}