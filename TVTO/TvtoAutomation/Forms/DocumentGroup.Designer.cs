namespace TvtoAutomation.Forms
{
    partial class DocumentGroup
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
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NN = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rexaButton1 = new TvtoAutomation.Components.RexaButton(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rexaLabel1 = new TvtoAutomation.Components.RexaLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rexaGrid1)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.Edit,
            this.Delete,
            this.NN});
            this.rexaGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rexaGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.rexaGrid1.GridColor = System.Drawing.Color.Black;
            this.rexaGrid1.Location = new System.Drawing.Point(314, 61);
            this.rexaGrid1.MultiSelect = false;
            this.rexaGrid1.Name = "rexaGrid1";
            this.rexaGrid1.ReadOnly = true;
            this.rexaGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rexaGrid1.Size = new System.Drawing.Size(582, 403);
            this.rexaGrid1.TabIndex = 2;
            this.rexaGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rexaGrid1_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "ویرایش";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "حذف";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // NN
            // 
            this.NN.HeaderText = "";
            this.NN.Name = "NN";
            this.NN.ReadOnly = true;
            this.NN.Text = "سِمَت ها";
            this.NN.ToolTipText = "برای مدیریت سِمَت ها کلیک کنید";
            this.NN.UseColumnTextForButtonValue = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.rexaButton1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.rexaLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 403);
            this.panel3.TabIndex = 3;
            // 
            // rexaButton1
            // 
            this.rexaButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.rexaButton1.ForeColor = System.Drawing.Color.Black;
            this.rexaButton1.Location = new System.Drawing.Point(20, 339);
            this.rexaButton1.Name = "rexaButton1";
            this.rexaButton1.Size = new System.Drawing.Size(108, 58);
            this.rexaButton1.TabIndex = 2;
            this.rexaButton1.Text = "ثبت";
            this.rexaButton1.UseVisualStyleBackColor = false;
            this.rexaButton1.Click += new System.EventHandler(this.rexaButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 31);
            this.textBox1.TabIndex = 1;
            // 
            // rexaLabel1
            // 
            this.rexaLabel1.AutoSize = true;
            this.rexaLabel1.Location = new System.Drawing.Point(239, 33);
            this.rexaLabel1.Name = "rexaLabel1";
            this.rexaLabel1.Size = new System.Drawing.Size(51, 24);
            this.rexaLabel1.TabIndex = 0;
            this.rexaLabel1.Text = "عنوان:";
            this.rexaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DocumentGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 501);
            this.Controls.Add(this.rexaGrid1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.Name = "DocumentGroup";
            this.Text = "گروه اسناد";
            this.Load += new System.EventHandler(this.DocumentGroup_Load);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.rexaGrid1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.rexaGrid1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.RexaGrid rexaGrid1;
        private System.Windows.Forms.Panel panel3;
        private Components.RexaButton rexaButton1;
        private System.Windows.Forms.TextBox textBox1;
        private Components.RexaLabel rexaLabel1;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn NN;
    }
}