namespace TvtoAutomation.Forms
{
    partial class Main
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
            this.rexaButton1 = new TvtoAutomation.Components.RexaButton(this.components);
            this.rexaButton2 = new TvtoAutomation.Components.RexaButton(this.components);
            this.rexaButton4 = new TvtoAutomation.Components.RexaButton(this.components);
            this.rexaButton5 = new TvtoAutomation.Components.RexaButton(this.components);
            this.rexaButton6 = new TvtoAutomation.Components.RexaButton(this.components);
            this.SuspendLayout();
            // 
            // rexaButton1
            // 
            this.rexaButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.rexaButton1.ForeColor = System.Drawing.Color.White;
            this.rexaButton1.Location = new System.Drawing.Point(85, 113);
            this.rexaButton1.Name = "rexaButton1";
            this.rexaButton1.Size = new System.Drawing.Size(307, 77);
            this.rexaButton1.TabIndex = 2;
            this.rexaButton1.Text = "ویرایش پروفایل";
            this.rexaButton1.UseVisualStyleBackColor = false;
            this.rexaButton1.Click += new System.EventHandler(this.rexaButton1_Click);
            // 
            // rexaButton2
            // 
            this.rexaButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.rexaButton2.ForeColor = System.Drawing.Color.White;
            this.rexaButton2.Location = new System.Drawing.Point(425, 113);
            this.rexaButton2.Name = "rexaButton2";
            this.rexaButton2.Size = new System.Drawing.Size(307, 77);
            this.rexaButton2.TabIndex = 2;
            this.rexaButton2.Text = "مدیریت کاربران";
            this.rexaButton2.UseVisualStyleBackColor = false;
            this.rexaButton2.Click += new System.EventHandler(this.rexaButton2_Click);
            // 
            // rexaButton4
            // 
            this.rexaButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.rexaButton4.ForeColor = System.Drawing.Color.White;
            this.rexaButton4.Location = new System.Drawing.Point(85, 196);
            this.rexaButton4.Name = "rexaButton4";
            this.rexaButton4.Size = new System.Drawing.Size(307, 77);
            this.rexaButton4.TabIndex = 2;
            this.rexaButton4.Text = "گروه نامه ها";
            this.rexaButton4.UseVisualStyleBackColor = false;
            this.rexaButton4.Click += new System.EventHandler(this.rexaButton4_Click);
            // 
            // rexaButton5
            // 
            this.rexaButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.rexaButton5.ForeColor = System.Drawing.Color.White;
            this.rexaButton5.Location = new System.Drawing.Point(425, 196);
            this.rexaButton5.Name = "rexaButton5";
            this.rexaButton5.Size = new System.Drawing.Size(307, 77);
            this.rexaButton5.TabIndex = 2;
            this.rexaButton5.Text = "نامه ها";
            this.rexaButton5.UseVisualStyleBackColor = false;
            this.rexaButton5.Click += new System.EventHandler(this.rexaButton5_Click);
            // 
            // rexaButton6
            // 
            this.rexaButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.rexaButton6.ForeColor = System.Drawing.Color.White;
            this.rexaButton6.Location = new System.Drawing.Point(85, 279);
            this.rexaButton6.Name = "rexaButton6";
            this.rexaButton6.Size = new System.Drawing.Size(307, 77);
            this.rexaButton6.TabIndex = 2;
            this.rexaButton6.Text = "درخواست امضا";
            this.rexaButton6.UseVisualStyleBackColor = false;
            this.rexaButton6.Click += new System.EventHandler(this.rexaButton6_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 482);
            this.Controls.Add(this.rexaButton5);
            this.Controls.Add(this.rexaButton6);
            this.Controls.Add(this.rexaButton2);
            this.Controls.Add(this.rexaButton4);
            this.Controls.Add(this.rexaButton1);
            this.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.Name = "Main";
            this.Text = "خانه";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Controls.SetChildIndex(this.rexaButton1, 0);
            this.Controls.SetChildIndex(this.rexaButton4, 0);
            this.Controls.SetChildIndex(this.rexaButton2, 0);
            this.Controls.SetChildIndex(this.rexaButton6, 0);
            this.Controls.SetChildIndex(this.rexaButton5, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.RexaButton rexaButton1;
        private Components.RexaButton rexaButton2;
        private Components.RexaButton rexaButton4;
        private Components.RexaButton rexaButton5;
        private Components.RexaButton rexaButton6;
    }
}