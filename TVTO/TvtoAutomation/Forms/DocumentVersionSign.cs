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
    public partial class DocumentVersionSign : Adam
    {
        public DocumentVersionSign()
        {
            InitializeComponent();
        }


        List<Models.v_Sign> sings;

        private void DocumentVersionSign_Load(object sender, EventArgs e)
        {
            MyReload();
        }

        private void MyReload()
        {
            sings = db.v_Signs.Where(x => x.Username == Program.this_user.Username)
                .Where(x => x.Status == "Not Seen")
                .ToList();
            rexaGrid1.DataSource = sings
                .Select(x => new
                {
                    Id = x.SignId,
                    //وضعیت = x.Status,
                    سمت = x.PositionName,
                    سند = x.DocumentTitle,
                })
                .ToList();
        }

        private void rexaGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.ColumnIndex <= 3)
            {

                int id = Convert.ToInt32(rexaGrid1.Rows[e.RowIndex].Cells[3]
                    .Value.ToString());

                int document_id = sings[e.RowIndex].DocumentId;
                int document_version_id = sings[e.RowIndex].DocumentVersion;
                string group_name = sings[e.RowIndex].DocumentGroupName;
                string group = sings[e.RowIndex].DocumentGroupName;
                string document_tilte = sings[e.RowIndex].DocumentTitle;

                if (e.ColumnIndex == 0)
                {
                    var current_document = db.DocumentSelectCommand().Where(x => x.Id == document_id).FirstOrDefault();
                    var current_document_version = db.DocumentVersionSelectCommand().Where(x => x.Id == document_version_id).FirstOrDefault();

                    var d = new DocumentVersionDraft();
                    d.current_document = current_document;
                    d.current_document_version = current_document_version;

                    d.textBox_Group.Text = group_name;
                    d.textBox_Title.Text = document_tilte;

                    d.ShowDialog();
                }
                else if (e.ColumnIndex == 1)
                {
                    // TODO
                    db.DocumentVersionSignUpdateCommand("OK", id);
                }
                else if (e.ColumnIndex == 2)
                {
                    db.DocumentVersionSignUpdateCommand("Canceled", id);

                }

                MyReload();
            }

        }
    }
}
