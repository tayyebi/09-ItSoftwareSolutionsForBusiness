using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TvtoAutomation.Masters;

namespace TvtoAutomation.Forms
{
    public partial class Register : Adam
    {
        public Register()
        {
            InitializeComponent();
        }


        // public Models.UserSelectCommandResult User { get; set; }


        byte[] SelectedImage = null;

        private void Register_Load(object sender, EventArgs e)
        {
            if (Program.this_user != null)
            {
                textBox1.Text
                     = Program.this_user.Username;
                textBox2.Text
                                     = Program.this_user.Password;
                textBox3.Text
                                     = Program.this_user.Password;
                textBox4.Text
                                     = Program.this_user.Firstname;
                textBox5.Text
                                     = Program.this_user.Lastname;


                rexaButton2.Text = "ویرایش";

                textBox1.ReadOnly = true;

                if (Program.this_user.ProfilePicture.Length > 10)
                {

                    SelectedImage = Program.this_user.ProfilePicture.ToArray();

                    pictureBox2.BackgroundImage
                =
                Image.FromStream(new MemoryStream(
                    Program.this_user.ProfilePicture.ToArray()
                    ));
                }



            }
        }

        private void rexaButton1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG|*.png|JPG|*.jpg|BMP|*.bmp|JPEG|*.jpeg|GIF|*.gif|TIF|*.tif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.BackgroundImage =
                    Image.FromFile(ofd.FileName);
                SelectedImage = File.ReadAllBytes(ofd.FileName);
            }
        }

        private void rexaButton2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("کلمه ی عبور با تکرار آن همخوانی ندارد");
                return;
            }
            if (Program.this_user != null)
            {
                // update
                Program.this_user = db.UserUpdateCommand(textBox1.Text,
                     textBox2.Text,
                     SelectedImage,
                     textBox4.Text,
                     textBox5.Text,
                     Program.this_user.IsAdmin,
                     Program.this_user.IsDeleted,
                     textBox1.Text
                     ).Select(x =>
                     new Models.UserSelectCommandResult
                     {
                         Firstname = x.Firstname,
                         Lastname = x.Lastname,
                         IsAdmin = x.IsAdmin,
                         IsDeleted = x.IsDeleted,
                         Username = x.Username,
                         ProfilePicture = x.ProfilePicture,
                         Password = x.Password
                     }).FirstOrDefault();
                MessageBox.Show("ویرایش با موفقیت انجام شد");
            }
            else
            {
                db.UserInsertCommand(textBox1.Text,
                    textBox2.Text,
                    SelectedImage,
                    textBox4.Text,
                    textBox5.Text,
                    false,
                    false
                    );
                MessageBox.Show("ثبت نام با موفقیت انجام شد");
            }
            Close();
        }
    }
}
