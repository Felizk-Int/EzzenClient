using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;

namespace Ezzen
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*TitleBar Drag*/
        private int mouseX = 0, mouseY = 0;
        private int posmousex = 400, posmousey = 0;
        private bool mouseDown = false;
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            posmousex = MousePosition.X - this.Left;
            posmousey = MousePosition.Y - this.Top;
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - posmousex;
                mouseY = MousePosition.Y - posmousey;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        /// <summary>
        /// Send Message.
        /// </summary>
        private void SendButton_Click(object sender, EventArgs e)
        {
            if (MsgPanel.Text == "") return;
            ChatBox.AppendText("You said:");
            ChatBox.AppendText("\n" + MsgPanel.Text + "\n");
            MsgPanel.Focus();
            MsgPanel.Text = "";
        }
        private bool keyEnter = false;
        private void MsgPanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) keyEnter = true;
        }

        private void MsgPanel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (keyEnter) SendButton_Click(sender, e);
        }

        private void MsgPanel_KeyUp(object sender, KeyEventArgs e)
        {
            keyEnter = false;
        }

        /// <summary>
        /// Chat Menu
        /// </summary>
        private void DropDown_MouseEnter(object sender, EventArgs e)
        {
            ChatMenu.Show();
            ChatMenu.BringToFront();
            CreateGroup.BackColor = System.Drawing.Color.FromArgb(0, Color.White);
            JoinGroup.BackColor = System.Drawing.Color.FromArgb(0, Color.White);
            LeaveGroup.BackColor = System.Drawing.Color.FromArgb(0, Color.White);
        }

        private void ChatMenu_MouseEnter(object sender, EventArgs e)
        {
            ChatMenu.Show();
        }

        private void ChatMenu_MouseLeave(object sender, EventArgs e)
        {
            ChatMenu.Hide();
        }

        private void SearchBox_MouseEnter(object sender, EventArgs e)
        {
            ChatMenu.Hide();
        }

        private void MessagesBox_MouseEnter(object sender, EventArgs e)
        {
            ChatMenu.Hide();
        }

        private void TitleBar_MouseEnter(object sender, EventArgs e)
        {
            ChatMenu.Hide();
        }

        private void SearchPanel_MouseEnter(object sender, EventArgs e)
        {
            ChatMenu.Hide();
        }

        private void SearchIcon_MouseEnter(object sender, EventArgs e)
        {
            ChatMenu.Hide();
        }

        private void MenuBar_MouseEnter(object sender, EventArgs e)
        {
            ChatMenu.Hide();
        }

        private void ChatBox_MouseEnter(object sender, EventArgs e)
        {
            ChatMenu.Hide();
        }

        private void CreateGroup_MouseEnter(object sender, EventArgs e)
        {
            CreateGroup.BackColor = System.Drawing.Color.FromArgb(80, Color.White);
            JoinGroup.BackColor = System.Drawing.Color.FromArgb(0, Color.White);
            LeaveGroup.BackColor = System.Drawing.Color.FromArgb(0, Color.White);
        }

        private void JoinGroup_MouseEnter(object sender, EventArgs e)
        {
            CreateGroup.BackColor = System.Drawing.Color.FromArgb(0, Color.White);
            JoinGroup.BackColor = System.Drawing.Color.FromArgb(80, Color.White);
            LeaveGroup.BackColor = System.Drawing.Color.FromArgb(0, Color.White);
        }

        private void LeaveGroup_MouseEnter(object sender, EventArgs e)
        {
            CreateGroup.BackColor = System.Drawing.Color.FromArgb(0, Color.White);
            JoinGroup.BackColor = System.Drawing.Color.FromArgb(0, Color.White);
            LeaveGroup.BackColor = System.Drawing.Color.FromArgb(80, Color.White);
        }

        /// <summary>
        /// Auto Scroll
        /// </summary>
        private void ChatBox_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            //ChatBox.SelectionStart = ChatBox.Text.Length;
            // scroll it automatically
            ChatBox.ScrollToCaret();
        }

        /// <summary>
        /// Menu Bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool menuBarOpen = false;
        private void ExpandButton_MouseClick(object sender, MouseEventArgs e)
        {
            menuBarOpen = !menuBarOpen;
            if (menuBarOpen)
            {
                MenuList.Show();
                MenuList.BringToFront();
                ChatRoomSel.BackColor = System.Drawing.Color.FromArgb(0, Color.White);
                SettingSel.BackColor = System.Drawing.Color.FromArgb(0, Color.White);
            }
            else
            {
                MenuList.Hide();
            }
        }

        private void ChatRoomSel_MouseEnter(object sender, EventArgs e)
        {
            ChatRoomSel.BackColor = System.Drawing.Color.FromArgb(80, Color.White);
        }

        private void ChatRoomSel_MouseLeave(object sender, EventArgs e)
        {
            ChatRoomSel.BackColor = System.Drawing.Color.FromArgb(0, Color.White);
        }

        private void SettingSel_MouseEnter(object sender, EventArgs e)
        {
            SettingSel.BackColor = System.Drawing.Color.FromArgb(80, Color.White);
        }

        private void SettingSel_MouseLeave(object sender, EventArgs e)
        {
            SettingSel.BackColor = System.Drawing.Color.FromArgb(0, Color.White);
        }

        private void ChatButton_Click(object sender, EventArgs e)
        {
            SettingPage.Hide();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SettingPage.Show();
            SettingPage.BringToFront();
        }

        private void ChatRoomSel_MouseClick(object sender, MouseEventArgs e)
        {
            ChatButton_Click(sender, e);
            ExpandButton_MouseClick(sender, e);
        }

        private void SettingSel_MouseClick(object sender, MouseEventArgs e)
        {
            SettingButton_Click(sender, e);
            ExpandButton_MouseClick(sender, e);
        }

        /// <summary>
        /// Group Manage
        /// </summary>
        private void CreateGroup_Click(object sender, EventArgs e)
        {
            CreateGroupForm cgf = new CreateGroupForm();
            cgf.Show();
        }

        private void JoinGroup_Click(object sender, EventArgs e)
        {
            JoinGroupForm jgf = new JoinGroupForm();
            jgf.Show();
        }


        /// <summary>
        /// Sign Out
        /// </summary>
        private void SignOutButton_Click(object sender, EventArgs e)
        {
            ChatButton_Click(sender, e);
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();

            Program.IsAlwaysLogin = false;
            File.WriteAllText("Config/user", String.Empty);
            using (StreamWriter writer = new StreamWriter("Config/user", true))
            {
                {
                    writer.WriteLine("[user] 0");
                    writer.WriteLine("[remember] 0");
                }
                writer.Close();
            }
        }

        /// <summary>
        /// Search
        /// </summary>
        private void SearchPanel_Enter(object sender, EventArgs e)
        {
            SearchPanel.Text = "";
            SearchPanel.ForeColor = Color.Black;
        }

        private void SearchPanel_Leave(object sender, EventArgs e)
        {
            if (SearchPanel.Text == "")
            {
                SearchPanel.Text = "Search";
                SearchPanel.ForeColor = Color.Silver;
            }
        }

        /// <summary>
        /// Onload MW & Enter MW
        /// </summary>

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            Program.CS.connect(Program.IPaddress);
            //Load Setting
            Dictionary<string, string> d = new Dictionary<string, string>();
            try
            {
                using (StreamReader sr = new StreamReader("Config/user"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] temp = line.Split(' ');
                        d[temp[0]] = temp[1];
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }

            if (d["[remember]"] == "0")
            {
                this.SignOutButton_Click(sender, e);
            }
            else
            {
                this.UsernameLabel.Text = d["[user]"];
            }
        }

        public void MainWindow_Enter(object sender, EventArgs e)
        {
            GroupPanel1.Controls.Clear();
            Program.GroupList.Sort();
            foreach (ChatGroup c in Program.GroupList)
            {
                GroupPanel1.Controls.Add(c);
            }
        }

        

        /// <summary>
        /// Operation Buttons
        /// </summary>
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (Program.IsAlwaysLogin)
            {
                File.WriteAllText("Config/user", String.Empty);
                using (StreamWriter writer = new StreamWriter("Config/user", true))
                {
                    {
                        writer.WriteLine("[user] " + this.UsernameLabel.Text);
                        writer.WriteLine("[remember] 1");
                    }
                    writer.Close();
                }
            }
            else
            {
                File.WriteAllText("Config/user", String.Empty);
                using (StreamWriter writer = new StreamWriter("Config/user", true))
                {
                    {
                        writer.WriteLine("[user] 0");
                        writer.WriteLine("[remember] 0");
                    }
                    writer.Close();
                }
            }
            Program.CS.disconnect();
            this.Close();
            Application.Exit();
        }
    }
}
