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
            if (keyEnter && MsgPanel.Text != "") SendButton_Click(sender, e);
        }

        private void MsgPanel_KeyUp(object sender, KeyEventArgs e)
        {
            keyEnter = false;
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
            this.Close();
        }

    }
}
