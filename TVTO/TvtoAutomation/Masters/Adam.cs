using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace TvtoAutomation.Masters
{
    public partial class Adam : Form
    {
        public Models.DcDataContext db = new Models.DcDataContext();
        public Adam()
        {
            InitializeComponent();

            Timer t = new Timer();
            t.Interval = 1000;
            t.Enabled = true;
            t.Tick += delegate
            {
                var currentDate = DateTime.Now;
                var p = new PersianCalendar();

                label3.Text = $"{currentDate.DayOfWeek}  {p.GetYear(currentDate)}/{p.GetMonth(currentDate)}/{p.GetDayOfMonth(currentDate)}";
            };
        }

        private void Adam_Load(object sender, EventArgs e)
        {
            if (Program.this_user != null 
     
                )
            {

                label1.Text = Program.this_user.Firstname + " " + Program.this_user.Lastname;
                label2.Text = db.v_UserPositions.Where(x => x.Username == Program.this_user.Username)
                    .Select(x=>x.Position)
                    .ToList().Aggregate("", (current, next) => current + " - " + next);

                if (Program.this_user
                .ProfilePicture.Length > 10)
                {
                    pictureBox1.BackgroundImage =
                         Image.FromStream(new MemoryStream(Program.this_user.ProfilePicture.ToArray()));
                }
            }
        }


        private void rexaButton3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
