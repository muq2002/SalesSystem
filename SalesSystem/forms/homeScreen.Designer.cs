namespace SalesSystem
{
    partial class homeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeScreen));
            this.openRegisterProductsScreen = new System.Windows.Forms.Button();
            this.openRegisterSalesScreen = new System.Windows.Forms.Button();
            this.openSettingSetting = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openRegisterProductsScreen
            // 
            this.openRegisterProductsScreen.Image = ((System.Drawing.Image)(resources.GetObject("openRegisterProductsScreen.Image")));
            this.openRegisterProductsScreen.Location = new System.Drawing.Point(721, 170);
            this.openRegisterProductsScreen.Name = "openRegisterProductsScreen";
            this.openRegisterProductsScreen.Size = new System.Drawing.Size(174, 188);
            this.openRegisterProductsScreen.TabIndex = 0;
            this.openRegisterProductsScreen.Text = "سجل المنتجات";
            this.openRegisterProductsScreen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openRegisterProductsScreen.UseVisualStyleBackColor = true;
            this.openRegisterProductsScreen.Click += new System.EventHandler(this.openRegisterProductsScreen_Click);
            // 
            // openRegisterSalesScreen
            // 
            this.openRegisterSalesScreen.Image = ((System.Drawing.Image)(resources.GetObject("openRegisterSalesScreen.Image")));
            this.openRegisterSalesScreen.Location = new System.Drawing.Point(520, 170);
            this.openRegisterSalesScreen.Name = "openRegisterSalesScreen";
            this.openRegisterSalesScreen.Size = new System.Drawing.Size(174, 188);
            this.openRegisterSalesScreen.TabIndex = 1;
            this.openRegisterSalesScreen.Text = "سجل المبيعات";
            this.openRegisterSalesScreen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openRegisterSalesScreen.UseVisualStyleBackColor = true;
            this.openRegisterSalesScreen.Click += new System.EventHandler(this.openRegisterSalesScreen_Click);
            // 
            // openSettingSetting
            // 
            this.openSettingSetting.Image = ((System.Drawing.Image)(resources.GetObject("openSettingSetting.Image")));
            this.openSettingSetting.Location = new System.Drawing.Point(331, 170);
            this.openSettingSetting.Name = "openSettingSetting";
            this.openSettingSetting.Size = new System.Drawing.Size(167, 188);
            this.openSettingSetting.TabIndex = 2;
            this.openSettingSetting.Text = "الاعدادت";
            this.openSettingSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openSettingSetting.UseVisualStyleBackColor = true;
            this.openSettingSetting.Click += new System.EventHandler(this.openSettingSetting_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(721, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 188);
            this.button1.TabIndex = 3;
            this.button1.Text = "الخروج";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 62);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // homeScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1149, 662);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openSettingSetting);
            this.Controls.Add(this.openRegisterSalesScreen);
            this.Controls.Add(this.openRegisterProductsScreen);
            this.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "homeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Screen  : Management Sales System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResizeEnd += new System.EventHandler(this.homeScreen_ResizeEnd);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openRegisterProductsScreen;
        private System.Windows.Forms.Button openRegisterSalesScreen;
        private System.Windows.Forms.Button openSettingSetting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

