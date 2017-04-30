using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ezzen
{
    public class ChatGroup : Button, IComparable
    {
        private string groupName;
        private string gid;
        private string latestMID = "0";

        //getters & setters
        public string GroupName { get => groupName; }
        public string Gid { get => gid; }
        public string LatestMID { get => latestMID; set => latestMID = value; }

        public ChatGroup(string gName, string gID)
        {
            this.groupName = gName;
            this.gid = gID;
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
        }

        public void chatGroup_MouseClick(object sender, MouseEventArgs e)
        {
            Program.MW.GroupName1.Text = groupName;
            Program.MW.GroupID1.Text = gid;
            Program.MW.GroupName1.Visible = true;
            Program.MW.GroupID1.Visible = true;
            Program.MW.ChatBox1.BringToFront();
            Program.MW.ChatBox1.Visible = true;
            Program.MW.ChatBox1.Text = "";
            Program.MW.MessagePanel1.Show();
            Program.MW.MsgPanel1.Show();
            Program.MW.MsgPanel1.Text = "";
            Program.MW.SendButton1.Show();
            //Load Message
        }

        public int CompareTo(object x)
        {
            return ((ChatGroup) x).latestMID.CompareTo(latestMID);
        }
    }
}
