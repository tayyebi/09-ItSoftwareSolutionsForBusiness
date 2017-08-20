namespace TvtoAutomation.Forms
{
    partial class Document
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
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rexaButton1 = new TvtoAutomation.Components.RexaButton(this.components);
            this.rexaButton2 = new TvtoAutomation.Components.RexaButton(this.components);
            this.rexaButton4 = new TvtoAutomation.Components.RexaButton(this.components);
            this.rexaButton5 = new TvtoAutomation.Components.RexaButton(this.components);
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
            this.Select});
            this.rexaGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.rexaGrid1.GridColor = System.Drawing.Color.Black;
            this.rexaGrid1.Location = new System.Drawing.Point(12, 114);
            this.rexaGrid1.MultiSelect = false;
            this.rexaGrid1.Name = "rexaGrid1";
            this.rexaGrid1.ReadOnly = true;
            this.rexaGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rexaGrid1.Size = new System.Drawing.Size(826, 325);
            this.rexaGrid1.TabIndex = 2;
            this.rexaGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rexaGrid1_CellContentClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Text = "انتخاب";
            this.Select.UseColumnTextForButtonValue = true;
            // 
            // rexaButton1
            // 
            this.rexaButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.rexaButton1.ForeColor = System.Drawing.Color.Black;
            this.rexaButton1.Location = new System.Drawing.Point(12, 70);
            this.rexaButton1.Name = "rexaButton1";
            this.rexaButton1.Size = new System.Drawing.Size(110, 38);
            this.rexaButton1.TabIndex = 3;
            this.rexaButton1.Text = "جدید";
            this.rexaButton1.UseVisualStyleBackColor = false;
            this.rexaButton1.Click += new System.EventHandler(this.rexaButton1_Click);
            // 
            // rexaButton2
            // 
            this.rexaButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.rexaButton2.ForeColor = System.Drawing.Color.Black;
            this.rexaButton2.Location = new System.Drawing.Point(128, 70);
            this.rexaButton2.Name = "rexaButton2";
            this.rexaButton2.Size = new System.Drawing.Size(110, 38);
            this.rexaButton2.TabIndex = 3;
            this.rexaButton2.Text = "ویرایش";
            this.rexaButton2.UseVisualStyleBackColor = false;
            this.rexaButton2.Visible = false;
            this.rexaButton2.Click += new System.EventHandler(this.rexaButton2_Click);
            // 
            // rexaButton4
            // 
            this.rexaButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.rexaButton4.ForeColor = System.Drawing.Color.Black;
            this.rexaButton4.Location = new System.Drawing.Point(244, 70);
            this.rexaButton4.Name = "rexaButton4";
            this.rexaButton4.Size = new System.Drawing.Size(110, 38);
            this.rexaButton4.TabIndex = 3;
            this.rexaButton4.Text = "حذف";
            this.rexaButton4.UseVisualStyleBackColor = false;
            this.rexaButton4.Visible = false;
            this.rexaButton4.Click += new System.EventHandler(this.rexaButton4_Click);
            // 
            // rexaButton5
            // 
            this.rexaButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.rexaButton5.ForeColor = System.Drawing.Color.Black;
            this.rexaButton5.Location = new System.Drawing.Point(360, 70);
            this.rexaButton5.Name = "rexaButton5";
            this.rexaButton5.Size = new System.Drawing.Size(110, 38);
            this.rexaButton5.TabIndex = 3;
            this.rexaButton5.Text = "مشاهده";
            this.rexaButton5.UseVisualStyleBackColor = false;
            this.rexaButton5.Visible = false;
            this.rexaButton5.Click += new System.EventHandler(this.rexaButton5_Click);
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 482);
            this.Controls.Add(this.rexaButton5);
            this.Controls.Add(this.rexaButton4);
            this.Controls.Add(this.rexaButton2);
            this.Controls.Add(this.rexaButton1);
            this.Controls.Add(this.rexaGrid1);
            this.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.Name = "Document";
            this.Text = "سند";
            this.Load += new System.EventHandler(this.Document_Load);
            this.Controls.SetChildIndex(this.rexaGrid1, 0);
            this.Controls.SetChildIndex(this.rexaButton1, 0);
            this.Controls.SetChildIndex(this.rexaButton2, 0);
            this.Controls.SetChildIndex(this.rexaButton4, 0);
            this.Controls.SetChildIndex(this.rexaButton5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.rexaGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.RexaGrid rexaGrid1;
        private Components.RexaButton rexaButton1;
        private Components.RexaButton rexaButton2;
        private Components.RexaButton rexaButton4;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private Components.RexaButton rexaButton5;
    }
}