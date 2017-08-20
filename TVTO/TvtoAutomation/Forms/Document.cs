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
    public partial class Document : Adam
    {
        public Document()
        {
            InitializeComponent();
        }

        public void MyReload()
        {
            rexaButton2.Visible =
                rexaButton5.Visible =
                rexaButton4.Visible = false;

            documents = db.DocumentSelectCommand().ToList();
            rexaGrid1.DataSource
                 = documents;
        }

        Models.DocumentSelectCommandResult selected_document;
        List<Models.DocumentSelectCommandResult> documents;

        private void Document_Load(object sender, EventArgs e)
        {
            MyReload();
        }

        private void rexaButton4_Click(object sender, EventArgs e)
        {
            Hide();
            new DocumentDraft { current_Dopcument = selected_document, IsUpdate = false }.ShowDialog();
            MyReload();
            Show();
        }

        private void rexaButton2_Click(object sender, EventArgs e)
        {
            Hide();
            new DocumentDraft { current_Dopcument = selected_document, IsUpdate = true }.ShowDialog();
            MyReload();
            Show();
        }

        private void rexaButton1_Click(object sender, EventArgs e)
        {
            Hide();
            new DocumentDraft().ShowDialog();
            MyReload();
            Show();
        }

        private void rexaGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_document = documents.Where(x => x.Id == Convert.ToInt32(rexaGrid1.Rows[e.RowIndex].Cells[1].Value.ToString())).FirstOrDefault();
            rexaButton2.Visible =
                rexaButton5.Visible =
                    rexaButton4.Visible = true;

        }

        private void rexaButton5_Click(object sender, EventArgs e)
        {
            Hide();
            var d = new DocumentDraft();
            d.current_Dopcument = selected_document;
            d.rexaButton1.Visible = false;
            d.comboBox1.Enabled = false;
            d.textBox1.ReadOnly = true;
            d.ShowDialog();
            MyReload();
            Show();
        }
    }
}
