using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvtoAutomation.Other
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            BackColor = Color.White;
            TransparencyKey = Color.White;

            Timer t = new Timer();
            t.Interval = 10;
            bool Increasing = true;
            int i = 0;
            Opacity = 0;
            t.Enabled = true;
            t.Tick += delegate
            {
                var opx = (double)i / 100;
                Opacity = opx;

                if (Increasing)
                {
                    i += 1;
                    if (i == 100)
                        Increasing = false;
                }
                else
                {
                    i -= 1;
                    if (i == 0)
                        Close();
                }
            };

        }
    }
}
