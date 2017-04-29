using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ezzen
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            Username.Text = "";
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            Password.Text = "";
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            if (Program.CS.login(Username.Text, Password.Text) != "LOGIN FAIL")
            {
                Program.MW.UsernameLabel1.Text = this.Username.Text;
                Program.MW.Show();
                Program.IsAlwaysLogin = RememberMe.Checked;
                Program.MW.UserIDLabel1.Text = Program.CS.ClientID;
                this.Close();
            }
            else
            {
                ErrorMessage.Show();
            }
            //temp
            /*Program.MW.UsernameLabel1.Text = this.Username.Text;
            Program.MW.Show();
            Program.IsAlwaysLogin = RememberMe.Checked;
            this.Close();*/
        }
        /// <summary>
        /// Window Drag
        /// </summary>
        private int mouseX = 0, mouseY = 0;
        private int posmousex = 400, posmousey = 0;
        private bool mouseDown = false;
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            posmousex = MousePosition.X - this.Left;
            posmousey = MousePosition.Y - this.Top;
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm reg = new RegForm();
            reg.Show();
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
    }
}
