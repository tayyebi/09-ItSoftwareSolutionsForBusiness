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
    public partial class Login : Adam
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void rexaButton2_Click(object sender, EventArgs e)
        {
            new Register().ShowDialog();
        }

        private void rexaButton1_Click(object sender, EventArgs e)
        {
            if (db.RexaLogin(textBox1.Text,
                textBox2.Text).FirstOrDefault().Stauts == "Success")
            {
                Program.this_user =
                    db.UserSelectCommand().Where(x => x.Username == textBox1.Text).FirstOrDefault();
                Hide();
                new Forms.Main().ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("نام کاربری یا کلمه ی عبور صحیح نیست");
            }
        }
    }
}
