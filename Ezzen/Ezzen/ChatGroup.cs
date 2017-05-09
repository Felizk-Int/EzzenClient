using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Ezzen
{
    public class ChatGroup : Button, IComparable
    {
        private string groupName;
        private string gid;
        private string latestMID = "0";
        private ChatBox chatbox;
        private string clientID;
        public GroupMessenger groupMessenger;


        //getters & setters
        public string GroupName { get => groupName; }
        public string Gid { get => gid; }
        public string LatestMID { get => latestMID; set => latestMID = value; }

        public ChatGroup(string gName, string gID, string clientID)
        {
            this.groupName = gName;
            this.gid = gID;
            this.clientID = clientID;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Font = new System.Drawing.Font("Tw Cen MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Width = 270;
            this.Height = 50;
            this.Margin = new Padding(3, 5, 0, 2);
            this.ForeColor = System.Drawing.Color.Black;
            this.BackColor = System.Drawing.Color.FromArgb(150,220, 220, 220);
            this.Text = groupName;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MouseClick += chatGroup_MouseClick;
            this.chatbox = new ChatBox(gName);
            this.groupMessenger = new GroupMessenger(gID, clientID, chatbox);
            groupMessenger.loadCache();
            groupMessenger.startThread();
        }

        public void chatGroup_MouseClick(object sender, MouseEventArgs e)
        {
            Program.MW.GroupName1.Text = groupName;
            Program.MW.GroupID1.Text = gid;
            Program.MW.GroupName1.Visible = true;
            Program.MW.GroupID1.Visible = true;
            chatbox.BringToFront();
            Program.MW.currentGroup = this;
            //Program.MW.ChatBox1.BringToFront();
            //Program.MW.ChatBox1.Visible = true;
            //Program.MW.ChatBox1.Text = "";
            //Program.MW.MessagePanel1.Show();
            //Program.MW.MsgPanel1.Show();
            //Program.MW.MsgPanel1.Text = "";
            //Program.MW.SendButton1.Show();
            //Load Message
        }

        public void removeChat(){
            groupMessenger.abortThread();
            groupMessenger.saveCache();
            chatbox.Hide();
            Program.MW.MessagesBox1.Controls.Remove(chatbox);
            this.Hide();
            Program.MW.GroupPanel1.Controls.Remove(this);
            Program.MW.GroupPanel1.Refresh();
        }

        public int CompareTo(object x)
        {
            return ((ChatGroup) x).latestMID.CompareTo(latestMID);
        }

        public GroupMessenger getGroupMessenger(){
            return groupMessenger;
        }
    }

    public class ChatBox : Panel
    {
        String groupName;
        RichTextBox chatScreen;
        TextBox chatInput;
        Button sendButton;

        public ChatBox(String groupName)
        {
            this.Size = new System.Drawing.Size(620,670);
            this.Location = new System.Drawing.Point(0,40);
            this.groupName = groupName;
            this.chatScreen = new RichTextBox();
            chatScreen.Size = new System.Drawing.Size(620,525);
            chatScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);

            this.chatInput = new TextBox();
            chatInput.Location = new System.Drawing.Point(0, 525);
            chatInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            chatInput.Size = new System.Drawing.Size(520,120);
            chatInput.KeyDown += new System.Windows.Forms.KeyEventHandler(chatBoxEnter);

            this.sendButton = new Button();
            sendButton.Location = new System.Drawing.Point(520, 525);
            sendButton.Size = new System.Drawing.Size(100,33);
            sendButton.Text = "Send";
            sendButton.Click += new System.EventHandler(sendButtonClick);

            this.Controls.Add(chatScreen);
            this.Controls.Add(chatInput);
            this.Controls.Add(sendButton);
            Program.MW.MessagesBox1.Controls.Add(this);
            
            this.Show();
            this.BringToFront();
        }

        
        delegate void StringArgReturningVoidDelegate(string text);

        public void AppendText(string text)
        {
            if (this.chatScreen.InvokeRequired)
            {
                this.chatScreen.Invoke(new StringArgReturningVoidDelegate(AppendText), new object[] { text });
            }
            else
            {
                this.chatScreen.AppendText(text);
                this.chatScreen.ScrollToCaret();
            }
        }

        public RichTextBox getChatScreen(){
            return chatScreen;
        }

        private void chatBoxEnter(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Enter) sendButtonClick(sender, e);
        }

        private void sendButtonClick(object sender, EventArgs e){
            Program.MW.Socket.send(groupName, Program.MW.UserIDLabel1.Text, chatInput.Text, DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fffffff", CultureInfo.InvariantCulture));
            chatInput.Focus();
            chatInput.Text = "";
        }
    }
}
