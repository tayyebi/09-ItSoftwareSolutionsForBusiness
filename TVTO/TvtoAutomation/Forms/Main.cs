using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TvtoAutomation.Masters;

namespace TvtoAutomation.Forms
{
    public partial class Main : Adam
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void rexaButton1_Click(object sender, EventArgs e)
        {
            Hide();
            new Register().ShowDialog();
            Show();
        }

        private void rexaButton2_Click(object sender, EventArgs e)
        {
            if (Program.this_user.IsAdmin)
            {
                Hide();
                new Users().ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("دسترسی به این بخش تنها برای ادمین سیستم مجاز است");
            }
        }

        private void rexaButton4_Click(object sender, EventArgs e)
        {
            Hide();
            new DocumentGroup().ShowDialog();
            Show();
        }

        private void rexaButton5_Click(object sender, EventArgs e)
        {
            Hide();
            new Document().ShowDialog();
            Show();
        }

        private void rexaButton6_Click(object sender, EventArgs e)
        {
            Hide();
            new DocumentVersionSign().ShowDialog();
            Show();
        }
    }
}
