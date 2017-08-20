namespace TvtoAutomation.Forms
{
    partial class Users
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
            this.rexaLabel1 = new TvtoAutomation.Components.RexaLabel(this.components);
            this.rexaGrid1 = new TvtoAutomation.Components.RexaGrid(this.components);
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.rexaLabel2 = new TvtoAutomation.Components.RexaLabel(this.components);
            this.rexaButton1 = new TvtoAutomation.Components.RexaButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rexaGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // rexaLabel1
            // 
            this.rexaLabel1.AutoSize = true;
            this.rexaLabel1.Location = new System.Drawing.Point(12, 69);
            this.rexaLabel1.Name = "rexaLabel1";
            this.rexaLabel1.Size = new System.Drawing.Size(87, 24);
            this.rexaLabel1.TabIndex = 4;
            this.rexaLabel1.Text = "انتخاب کاربر";
            this.rexaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rexaGrid1
            // 
            this.rexaGrid1.AllowUserToAddRows = false;
            this.rexaGrid1.AllowUserToDeleteRows = false;
            this.rexaGrid1.AllowUserToOrderColumns = true;
            this.rexaGrid1.BackgroundColor = System.Drawing.Color.White;
            this.rexaGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rexaGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.rexaGrid1.GridColor = System.Drawing.Color.Black;
            this.rexaGrid1.Location = new System.Drawing.Point(12, 96);
            this.rexaGrid1.MultiSelect = false;
            this.rexaGrid1.Name = "rexaGrid1";
            this.rexaGrid1.ReadOnly = true;
            this.rexaGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rexaGrid1.Size = new System.Drawing.Size(695, 83);
            this.rexaGrid1.TabIndex = 5;
            this.rexaGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rexaGrid1_CellContentClick);
            this.rexaGrid1.SelectionChanged += new System.EventHandler(this.rexaGrid1_SelectionChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(16, 217);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(691, 160);
            this.checkedListBox1.TabIndex = 6;
            // 
            // rexaLabel2
            // 
            this.rexaLabel2.AutoSize = true;
            this.rexaLabel2.Location = new System.Drawing.Point(12, 190);
            this.rexaLabel2.Name = "rexaLabel2";
            this.rexaLabel2.Size = new System.Drawing.Size(63, 24);
            this.rexaLabel2.TabIndex = 4;
            this.rexaLabel2.Text = "سمت ها";
            this.rexaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rexaButton1
            // 
            this.rexaButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.rexaButton1.ForeColor = System.Drawing.Color.Black;
            this.rexaButton1.Location = new System.Drawing.Point(402, 386);
            this.rexaButton1.Name = "rexaButton1";
            this.rexaButton1.Size = new System.Drawing.Size(305, 51);
            this.rexaButton1.TabIndex = 7;
            this.rexaButton1.Text = "ثبت تغییرات";
            this.rexaButton1.UseVisualStyleBackColor = false;
            this.rexaButton1.Click += new System.EventHandler(this.rexaButton1_Click_1);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 480);
            this.Controls.Add(this.rexaButton1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.rexaGrid1);
            this.Controls.Add(this.rexaLabel2);
            this.Controls.Add(this.rexaLabel1);
            this.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.Name = "Users";
            this.Text = "مدیریت کاربران";
            this.Load += new System.EventHandler(this.Users_Load);
            this.Controls.SetChildIndex(this.rexaLabel1, 0);
            this.Controls.SetChildIndex(this.rexaLabel2, 0);
            this.Controls.SetChildIndex(this.rexaGrid1, 0);
            this.Controls.SetChildIndex(this.checkedListBox1, 0);
            this.Controls.SetChildIndex(this.rexaButton1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.rexaGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Components.RexaLabel rexaLabel1;
        private Components.RexaGrid rexaGrid1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private Components.RexaLabel rexaLabel2;
        private Components.RexaButton rexaButton1;
    }
}