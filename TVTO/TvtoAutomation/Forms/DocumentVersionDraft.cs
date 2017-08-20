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
    public partial class DocumentVersionDraft : Adam
    {
        public DocumentVersionDraft()
        {
            InitializeComponent();
        }

        public Models.DocumentSelectCommandResult current_document { get; set; }
        public Models.DocumentVersionSelectCommandResult current_document_version { get; set; }

        private void DocumentVersionDraft_Load(object sender, EventArgs e)
        {
            if (current_document_version != null)
            {
                textBox1.ReadOnly = true;
                rexaButton1.Visible = false;
                textBox1.Text = current_document_version.Body;
            }
        }

        private void rexaButton1_Click(object sender, EventArgs e)
        {
            var this_doc = db.DocumentVersionInsertCommand(current_document.Id, DateTime.Now, textBox1.Text, Program.this_user.Username, false).FirstOrDefault();
            foreach (var item in db.DocumentGroupSignSelectCommand().Where(x=>x.DocumentGroupId == current_document.DocumentGroupId).ToList())
            {
                db.DocumentVersionSignInsertCommand(this_doc.Id, item.Id, Program.this_user.Username, "Not Seen");
            }
            MessageBox.Show("ثبت با موفقیت انجام شد");
            Close();
        }
    }
}
