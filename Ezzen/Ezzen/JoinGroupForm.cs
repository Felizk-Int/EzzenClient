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
    public partial class JoinGroupForm : Form
    {
        public JoinGroupForm()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Join_Click(object sender, EventArgs e)
        {
            Program.CS.joinGroup(GroupID.Text);
            ChatGroup cg = new ChatGroup(GroupID.Text, GroupID.Text);
            //Program.MW.GroupPanel1.Controls.Add(cg);
            Program.GroupList.Add(cg);
            Program.MW.MainWindow_Enter(sender, e);
            this.Close();
        }
    }
}
