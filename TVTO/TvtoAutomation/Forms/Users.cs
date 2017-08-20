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
    public partial class Users : Adam
    {
        public Users()
        {
            InitializeComponent();
        }


        List<Models.PositionSelectCommandResult> positions;
        string Username;
        private void Users_Load(object sender, EventArgs e)
        {
            var query = db.UserSelectCommand()
                .Select(x => new
                {
                    نام_کاربری = x.Username,
                    نام = x.Firstname,
                    نام_خانوادگی = x.Lastname,
                    ادمین_است = x.IsAdmin
                })
                .ToList();
            rexaGrid1.DataSource = query;
            if (query.Count > 0)
            {

                // TODO
                // change seleced index of gridview
            }
        }

        private void rexaGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {



        }

        private void rexaGrid1_SelectionChanged(object sender, EventArgs e)
        {
            positions = db.PositionSelectCommand().ToList();

            Username =
            rexaGrid1.SelectedRows[0]
                .Cells[0].Value.ToString();

            var user_positions = db
                .UserPositionSelectCommand()
                .ToList()
                .Where(x => x.Username == Username);


            checkedListBox1.Items.Clear();

            foreach (var item in positions)
            {
                int exists =
                    user_positions.Where(x => x.PositionId == item.Id)
                    .Count();
                if (exists
                    == 1)
                {
                    checkedListBox1.Items.Add(item.Name, true);
                }
                else
                {
                    checkedListBox1.Items.Add(item.Name, false);
                }

            }
        }

        private void rexaButton1_Click_1(object sender, EventArgs e)
        {

            db.UserPositionDeleteCommand(Username, null);

            foreach (var i in checkedListBox1.CheckedIndices.Cast<int>().ToArray())
            {
                var item = positions[i];
                db.UserPositionInsertCommand(Username, item.Id);
            }



        }
    }
}
