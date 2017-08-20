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
    public partial class DocumentDraft : Adam
    {
        public DocumentDraft()
        {
            InitializeComponent();
        }

        public Models.DocumentSelectCommandResult current_Dopcument { get; set; }
        public bool IsUpdate { get; set; }

        private void DocumentDraft_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource
                 = db.DocumentGroupSelectCommand().ToList();
            if (current_Dopcument != null)
            {
                textBox1.Text =
                    current_Dopcument.Title;
                comboBox1.SelectedValue = current_Dopcument.DocumentGroupId;
                rexaButton2.Visible = true;
            }
            if (!IsUpdate && current_Dopcument != null)
            {
                comboBox1.Enabled = false;
                textBox1.ReadOnly = true;
                rexaButton1.Text = "حذف";
            }
        }

        private void rexaButton1_Click(object sender, EventArgs e)
        {
            Hide();
            if (current_Dopcument != null && IsUpdate)
            {
                var document = db.DocumentUpdateCommand(textBox1.Text, current_Dopcument.Create, current_Dopcument.OwnerUsername, int.Parse(comboBox1.SelectedValue.ToString())
                      , current_Dopcument.IsDeleted, current_Dopcument.Id)

                      .Select(x => new Models.DocumentSelectCommandResult
                      {
                          Id = x.Id,
                          Create = x.Create,
                          DocumentGroupId = x.DocumentGroupId,
                          OwnerUsername = x.OwnerUsername,
                          IsDeleted = x.IsDeleted,
                          Title = x.Title
                      })
                      .FirstOrDefault();

                var dvd = new DocumentVersionDraft { current_document = document };
                dvd.textBox_Group.Text = comboBox1.Text;
                dvd.textBox_Title.Text = textBox1.Text;
                dvd.ShowDialog();
            }
            else if (current_Dopcument != null && !IsUpdate)
            {
                db.DocumentDeleteCommand(current_Dopcument.Id);
            }
            else if (current_Dopcument == null)
            {
                var document =
                db.DocumentInsertCommand(textBox1.Text, DateTime.Now, Program.this_user.Username, int.Parse(comboBox1.SelectedValue.ToString())
                    , false)
                      .Select(x => new Models.DocumentSelectCommandResult
                      {
                          Id = x.Id,
                          Create = x.Create,
                          DocumentGroupId = x.DocumentGroupId,
                          OwnerUsername = x.OwnerUsername,
                          IsDeleted = x.IsDeleted,
                          Title = x.Title
                      })
                      .FirstOrDefault();

                var dvd = new DocumentVersionDraft { current_document = document };
                dvd.textBox_Group.Text = comboBox1.Text;
                dvd.textBox_Title.Text = textBox1.Text;
                dvd.ShowDialog();
            }
            Close();
        }

        private void rexaButton2_Click(object sender, EventArgs e)
        {
            var last_document = db.DocumentVersionSelectCommand()
                    .Where(x => x.DocumentId == current_Dopcument.Id)
                    .OrderByDescending(x => x.Id)
                    .FirstOrDefault();

            if (last_document == null)
            {
                MessageBox.Show("هیچ نسخه ای برای این سند ثبت نشده است");
                return;
            }

            var dvd = new DocumentVersionDraft
            {
                current_document_version = last_document

            };
            dvd.textBox_Group.Text = comboBox1.Text;
            dvd.textBox_Title.Text = textBox1.Text;
            dvd.ShowDialog();
        }
    }
}

