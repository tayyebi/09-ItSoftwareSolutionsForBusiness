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
    public partial class DocumentGroupSign : Adam
    {
        public Models.DocumentGroupSelectCommandResult selected_documentgroup { get; set; }
        public List<Models.PositionSelectCommandResult> positions { get; set; }

        public DocumentGroupSign()
        {
            InitializeComponent();
        }

        List<Models.DocumentGroupSignSelectCommandResult> document_group_signs;

        private void DocumentGroupSign_Load(object sender, EventArgs e)
        {
            document_group_signs =
                     db.DocumentGroupSignSelectCommand().Where(x => x.DocumentGroupId == selected_documentgroup.Id).ToList();

            positions = db.PositionSelectCommand().ToList();

            foreach (var position in positions)
            {
                checkedListBox1.Items.Add(position.Name,
                    document_group_signs.Where(x => x.PositionId
                    == position.Id).Count() == 1
                    );


            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var item = positions[e.Index];

            if (e.NewValue == CheckState.Unchecked)
            {
                db.DocumentGroupSignDeleteCommand(selected_documentgroup.Id, item.Id);
            }
            else if (e.NewValue == CheckState.Checked)
            {
                db.DocumentGroupSignInsertCommand(selected_documentgroup.Id, item.Id);
            }
        }
    }
}