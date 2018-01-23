namespace TelecomSampleApplication
{
    partial class TelecomForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLBL = new System.Windows.Forms.ToolStripStatusLabel();
            this.RunSampleBTN = new System.Windows.Forms.Button();
            this.ResultsTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLBL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 294);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(492, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLBL
            // 
            this.StatusLBL.Name = "StatusLBL";
            this.StatusLBL.Size = new System.Drawing.Size(76, 17);
            this.StatusLBL.Text = "Status: Ready";
            // 
            // RunSampleBTN
            // 
            this.RunSampleBTN.Location = new System.Drawing.Point(387, 5);
            this.RunSampleBTN.Name = "RunSampleBTN";
            this.RunSampleBTN.Size = new System.Drawing.Size(93, 23);
            this.RunSampleBTN.TabIndex = 10;
            this.RunSampleBTN.Text = "Run Sample";
            this.RunSampleBTN.UseVisualStyleBackColor = true;
            this.RunSampleBTN.Click += new System.EventHandler(this.RunSampleBTN_Click);
            // 
            // ResultsTB
            // 
            this.ResultsTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsTB.Location = new System.Drawing.Point(12, 38);
            this.ResultsTB.Multiline = true;
            this.ResultsTB.Name = "ResultsTB";
            this.ResultsTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTB.Size = new System.Drawing.Size(468, 244);
            this.ResultsTB.TabIndex = 12;
            this.ResultsTB.WordWrap = false;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(256, 7);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(100, 20);
            this.PasswordTB.TabIndex = 9;
            this.PasswordTB.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password:";
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(75, 5);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(100, 20);
            this.UserNameTB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "UserName:";
            // 
            // TelecomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 316);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.RunSampleBTN);
            this.Controls.Add(this.ResultsTB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "TelecomForm";
            this.RightToLeftLayout = true;
            this.Text = "EZTaxWebService Sample Application";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLBL;
        private System.Windows.Forms.Button RunSampleBTN;
        private System.Windows.Forms.TextBox ResultsTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.Label label1;
    }
}

