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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            Username.Text = "";
        }

        private void PW_Enter(object sender, EventArgs e)
        {
            PW.Text = "";
        }

        private void PWRe_Enter(object sender, EventArgs e)
        {
            PWRe.Text = "";
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (PW.Text == PWRe.Text)
            {
                string str = Program.CS.signup(Username.Text, PW.Text);
                for (int i = 0; i < 10000000; i++) ;
                Console.WriteLine("Sign up message: " + str);
                if (str == "SIGNUP SUCCEED")
                {
                    this.Close();
                }
                else
                {
                    //Console.Write("Error message: " + str);
                    ErrorMessage.Text = "Oops! Something went wrong.";
                    ErrorMessage.Show();
                }
            } else
            {
                ErrorMessage.Text = "Passwords must be the same.";
                ErrorMessage.Show();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
