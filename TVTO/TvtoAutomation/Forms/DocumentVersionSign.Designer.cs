namespace TvtoAutomation.Forms
{
    partial class DocumentVersionSign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rexaGrid1 = new TvtoAutomation.Components.RexaGrid(this.components);
            this.مشاهده = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ok = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Canceled = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rexaGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // rexaGrid1
            // 
            this.rexaGrid1.AllowUserToAddRows = false;
            this.rexaGrid1.AllowUserToDeleteRows = false;
            this.rexaGrid1.AllowUserToOrderColumns = true;
            this.rexaGrid1.BackgroundColor = System.Drawing.Color.White;
            this.rexaGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rexaGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.مشاهده,
            this.Ok,
            this.Canceled});
            this.rexaGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rexaGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.rexaGrid1.GridColor = System.Drawing.Color.Black;
            this.rexaGrid1.Location = new System.Drawing.Point(0, 61);
            this.rexaGrid1.MultiSelect = false;
            this.rexaGrid1.Name = "rexaGrid1";
            this.rexaGrid1.ReadOnly = true;
            this.rexaGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rexaGrid1.Size = new System.Drawing.Size(826, 403);
            this.rexaGrid1.TabIndex = 2;
            this.rexaGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rexaGrid1_CellContentClick);
            // 
            // مشاهده
            // 
            this.مشاهده.HeaderText = "";
            this.مشاهده.Name = "مشاهده";
            this.مشاهده.ReadOnly = true;
            this.مشاهده.Text = "مشاهده";
            this.مشاهده.UseColumnTextForButtonValue = true;
            // 
            // Ok
            // 
            this.Ok.HeaderText = "";
            this.Ok.Name = "Ok";
            this.Ok.ReadOnly = true;
            this.Ok.Text = "تائید";
            this.Ok.UseColumnTextForButtonValue = true;
            // 
            // Canceled
            // 
            this.Canceled.HeaderText = "";
            this.Canceled.Name = "Canceled";
            this.Canceled.ReadOnly = true;
            this.Canceled.Text = "عدم تائید";
            this.Canceled.UseColumnTextForButtonValue = true;
            // 
            // DocumentVersionSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 501);
            this.Controls.Add(this.rexaGrid1);
            this.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.Name = "DocumentVersionSign";
            this.Text = "درخواست های امضا";
            this.Load += new System.EventHandler(this.DocumentVersionSign_Load);
            this.Controls.SetChildIndex(this.rexaGrid1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.rexaGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.RexaGrid rexaGrid1;
        private System.Windows.Forms.DataGridViewButtonColumn مشاهده;
        private System.Windows.Forms.DataGridViewButtonColumn Ok;
        private System.Windows.Forms.DataGridViewButtonColumn Canceled;
    }
}