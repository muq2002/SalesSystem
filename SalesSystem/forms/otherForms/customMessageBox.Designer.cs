namespace SalesSystem.forms.otherForms
{
    partial class customMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customMessageBox));
            this.label1 = new System.Windows.Forms.Label();
            this.exitBTN = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.agreeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exitBTN)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(407, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "تسجيل المنتجات وادارتها";
            // 
            // exitBTN
            // 
            this.exitBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.exitBTN.Image = ((System.Drawing.Image)(resources.GetObject("exitBTN.Image")));
            this.exitBTN.Location = new System.Drawing.Point(0, 0);
            this.exitBTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(40, 30);
            this.exitBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBTN.TabIndex = 1;
            this.exitBTN.TabStop = false;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exitBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 30);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.agreeButton);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.textMessage);
            this.panel2.Controls.Add(this.yesButton);
            this.panel2.Controls.Add(this.noButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 226);
            this.panel2.TabIndex = 5;
            // 
            // agreeButton
            // 
            this.agreeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agreeButton.Location = new System.Drawing.Point(262, 163);
            this.agreeButton.Name = "agreeButton";
            this.agreeButton.Size = new System.Drawing.Size(120, 50);
            this.agreeButton.TabIndex = 9;
            this.agreeButton.Text = "موافق";
            this.agreeButton.UseVisualStyleBackColor = true;
            this.agreeButton.Visible = false;
            this.agreeButton.Click += new System.EventHandler(this.agreeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(489, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // textMessage
            // 
            this.textMessage.BackColor = System.Drawing.SystemColors.Control;
            this.textMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMessage.Location = new System.Drawing.Point(44, 20);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(426, 137);
            this.textMessage.TabIndex = 7;
            this.textMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textMessage.TextChanged += new System.EventHandler(this.textMessage_TextChanged);
            // 
            // yesButton
            // 
            this.yesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesButton.Location = new System.Drawing.Point(181, 163);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(120, 50);
            this.yesButton.TabIndex = 6;
            this.yesButton.Text = "نعم";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noButton.Location = new System.Drawing.Point(55, 163);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(120, 50);
            this.noButton.TabIndex = 5;
            this.noButton.Text = "لا";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // customMessageBox
            // 
            this.AcceptButton = this.noButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(663, 256);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "customMessageBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customMessageBox";
            this.Load += new System.EventHandler(this.customMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitBTN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox exitBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button agreeButton;
    }
}