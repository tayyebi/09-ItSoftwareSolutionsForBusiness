namespace TvtoAutomation.Forms
{
    partial class DocumentVersionDraft
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
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.rexaLabel1 = new TvtoAutomation.Components.RexaLabel(this.components);
            this.rexaLabel2 = new TvtoAutomation.Components.RexaLabel(this.components);
            this.textBox_Group = new System.Windows.Forms.TextBox();
            this.rexaLabel3 = new TvtoAutomation.Components.RexaLabel(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rexaButton1 = new TvtoAutomation.Components.RexaButton(this.components);
            this.SuspendLayout();
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(173, 71);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.ReadOnly = true;
            this.textBox_Title.Size = new System.Drawing.Size(251, 31);
            this.textBox_Title.TabIndex = 3;
            // 
            // rexaLabel1
            // 
            this.rexaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(139)))), ((int)(((byte)(52)))));
            this.rexaLabel1.ForeColor = System.Drawing.Color.White;
            this.rexaLabel1.Location = new System.Drawing.Point(12, 64);
            this.rexaLabel1.Name = "rexaLabel1";
            this.rexaLabel1.Size = new System.Drawing.Size(155, 44);
            this.rexaLabel1.TabIndex = 8;
            this.rexaLabel1.Text = "عنوان:";
            this.rexaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rexaLabel2
            // 
            this.rexaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(139)))), ((int)(((byte)(52)))));
            this.rexaLabel2.ForeColor = System.Drawing.Color.White;
            this.rexaLabel2.Location = new System.Drawing.Point(12, 131);
            this.rexaLabel2.Name = "rexaLabel2";
            this.rexaLabel2.Size = new System.Drawing.Size(155, 44);
            this.rexaLabel2.TabIndex = 8;
            this.rexaLabel2.Text = "گروه:";
            this.rexaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Group
            // 
            this.textBox_Group.Location = new System.Drawing.Point(173, 138);
            this.textBox_Group.Name = "textBox_Group";
            this.textBox_Group.ReadOnly = true;
            this.textBox_Group.Size = new System.Drawing.Size(251, 31);
            this.textBox_Group.TabIndex = 3;
            // 
            // rexaLabel3
            // 
            this.rexaLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(139)))), ((int)(((byte)(52)))));
            this.rexaLabel3.ForeColor = System.Drawing.Color.White;
            this.rexaLabel3.Location = new System.Drawing.Point(12, 202);
            this.rexaLabel3.Name = "rexaLabel3";
            this.rexaLabel3.Size = new System.Drawing.Size(155, 44);
            this.rexaLabel3.TabIndex = 8;
            this.rexaLabel3.Text = "متن:";
            this.rexaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 202);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(608, 177);
            this.textBox1.TabIndex = 3;
            // 
            // rexaButton1
            // 
            this.rexaButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.rexaButton1.ForeColor = System.Drawing.Color.Black;
            this.rexaButton1.Location = new System.Drawing.Point(690, 397);
            this.rexaButton1.Name = "rexaButton1";
            this.rexaButton1.Size = new System.Drawing.Size(77, 51);
            this.rexaButton1.TabIndex = 9;
            this.rexaButton1.Text = "ثبت";
            this.rexaButton1.UseVisualStyleBackColor = false;
            this.rexaButton1.Click += new System.EventHandler(this.rexaButton1_Click);
            // 
            // DocumentVersionDraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 503);
            this.Controls.Add(this.rexaButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_Group);
            this.Controls.Add(this.rexaLabel3);
            this.Controls.Add(this.rexaLabel2);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.rexaLabel1);
            this.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.Name = "DocumentVersionDraft";
            this.Text = "پیش نویس سند";
            this.Load += new System.EventHandler(this.DocumentVersionDraft_Load);
            this.Controls.SetChildIndex(this.rexaLabel1, 0);
            this.Controls.SetChildIndex(this.textBox_Title, 0);
            this.Controls.SetChildIndex(this.rexaLabel2, 0);
            this.Controls.SetChildIndex(this.rexaLabel3, 0);
            this.Controls.SetChildIndex(this.textBox_Group, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.rexaButton1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Components.RexaLabel rexaLabel1;
        private Components.RexaLabel rexaLabel2;
        public System.Windows.Forms.TextBox textBox_Group;
        public System.Windows.Forms.TextBox textBox_Title;
        private Components.RexaLabel rexaLabel3;
        public System.Windows.Forms.TextBox textBox1;
        private Components.RexaButton rexaButton1;
    }
}