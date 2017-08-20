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
    public partial class DocumentGroup : Adam
    {
        public DocumentGroup()
        {
            InitializeComponent();
        }

        public Models.DocumentGroupSelectCommandResult current_selected;

        private Mode currentMode;

        public Mode CurrentMode
        {
            get { return currentMode; }
            set
            {

                switch (value)
                {
                    case Mode.Insert:
                        textBox1.Text = "";
                        break;
                    case Mode.Update:
                        textBox1.Text = current_selected.Name;
                        break;
                    case Mode.Delete:
                        textBox1.Text = current_selected.Name;
                        break;

                }

                currentMode = value;

            }
        }



        public enum Mode
        {
            Insert,
            Update,
            Delete
        }

        private void DocumentGroup_Load(object sender, EventArgs e)
        {
            MyReload();
        }

        private void MyReload()
        {
            rexaGrid1.DataSource = db.DocumentGroupSelectCommand().ToList();
        }

        private void rexaButton1_Click(object sender, EventArgs e)
        {

            switch (CurrentMode)
            {
                case Mode.Insert:
                    db.DocumentGroupInsertCommand(textBox1.Text);
                    break;
                case Mode.Update:
                    db.DocumentGroupUpdateCommand(textBox1.Text, current_selected.Id, current_selected.Id);
                    break;
                case Mode.Delete:
                    db.DocumentGroupDeleteCommand(current_selected.Id);
                    break;
            }
            CurrentMode = Mode.Insert;



            MyReload();
        }

        private void rexaGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                int selected_id = int.Parse(rexaGrid1.Rows[e.RowIndex].Cells[3].Value.ToString());
                current_selected = db.DocumentGroupSelectCommand().Where(x => x.Id == selected_id).FirstOrDefault();

                if (e.ColumnIndex == 0)
                {
                    CurrentMode = Mode.Update;
                }
                else if (e.ColumnIndex == 1)
                {
                    // TODO

                    CurrentMode = Mode.Delete;
                }
                else if (e.ColumnIndex == 2)
                {
                    new DocumentGroupSign { selected_documentgroup = current_selected }.ShowDialog();
                }
            }

        }
    }
}
