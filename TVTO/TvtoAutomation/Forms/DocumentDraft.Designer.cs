namespace TvtoAutomation.Forms
{
    partial class DocumentDraft
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rexaLabel1 = new TvtoAutomation.Components.RexaLabel(this.components);
            this.rexaButton1 = new TvtoAutomation.Components.RexaButton(this.components);
            this.rexaLabel2 = new TvtoAutomation.Components.RexaLabel(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rexaButton2 = new TvtoAutomation.Components.RexaButton(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 31);
            this.textBox1.TabIndex = 9;
            // 
            // rexaLabel1
            // 
            this.rexaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(139)))), ((int)(((byte)(52)))));
            this.rexaLabel1.ForeColor = System.Drawing.Color.White;
            this.rexaLabel1.Location = new System.Drawing.Point(27, 206);
            this.rexaLabel1.Name = "rexaLabel1";
            this.rexaLabel1.Size = new System.Drawing.Size(155, 44);
            this.rexaLabel1.TabIndex = 12;
            this.rexaLabel1.Text = "عنوان:";
            this.rexaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rexaButton1
            // 
            this.rexaButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.rexaButton1.ForeColor = System.Drawing.Color.Black;
            this.rexaButton1.Location = new System.Drawing.Point(104, 288);
            this.rexaButton1.Name = "rexaButton1";
            this.rexaButton1.Size = new System.Drawing.Size(143, 44);
            this.rexaButton1.TabIndex = 13;
            this.rexaButton1.Text = "ثبت و ویرایش";
            this.rexaButton1.UseVisualStyleBackColor = false;
            this.rexaButton1.Click += new System.EventHandler(this.rexaButton1_Click);
            // 
            // rexaLabel2
            // 
            this.rexaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(139)))), ((int)(((byte)(52)))));
            this.rexaLabel2.ForeColor = System.Drawing.Color.White;
            this.rexaLabel2.Location = new System.Drawing.Point(27, 143);
            this.rexaLabel2.Name = "rexaLabel2";
            this.rexaLabel2.Size = new System.Drawing.Size(155, 44);
            this.rexaLabel2.TabIndex = 12;
            this.rexaLabel2.Text = "گروه:";
            this.rexaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(191, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 32);
            this.comboBox1.TabIndex = 14;
            // 
            // rexaButton2
            // 
            this.rexaButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.rexaButton2.ForeColor = System.Drawing.Color.Black;
            this.rexaButton2.Location = new System.Drawing.Point(253, 288);
            this.rexaButton2.Name = "rexaButton2";
            this.rexaButton2.Size = new System.Drawing.Size(75, 44);
            this.rexaButton2.TabIndex = 13;
            this.rexaButton2.Text = "مشاهده";
            this.rexaButton2.UseVisualStyleBackColor = false;
            this.rexaButton2.Click += new System.EventHandler(this.rexaButton2_Click);
            // 
            // DocumentDraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 482);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rexaButton2);
            this.Controls.Add(this.rexaButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rexaLabel2);
            this.Controls.Add(this.rexaLabel1);
            this.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.Name = "DocumentDraft";
            this.Text = "DocumentDraft";
            this.Load += new System.EventHandler(this.DocumentDraft_Load);
            this.Controls.SetChildIndex(this.rexaLabel1, 0);
            this.Controls.SetChildIndex(this.rexaLabel2, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.rexaButton1, 0);
            this.Controls.SetChildIndex(this.rexaButton2, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Components.RexaLabel rexaLabel1;
        private Components.RexaLabel rexaLabel2;
        private Components.RexaButton rexaButton2;
        public Components.RexaButton rexaButton1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}