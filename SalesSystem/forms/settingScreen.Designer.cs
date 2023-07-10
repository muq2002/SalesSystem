namespace SalesSystem.forms
{
    partial class settingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.setPasswordText = new System.Windows.Forms.TextBox();
            this.setUserrnameText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activateExpireDate = new System.Windows.Forms.TextBox();
            this.activateNubmerText = new System.Windows.Forms.TextBox();
            this.serialNumberText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveChanges = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.closeForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 30);
            this.panel1.TabIndex = 4;
            // 
            // closeForm
            // 
            this.closeForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.closeForm.Image = ((System.Drawing.Image)(resources.GetObject("closeForm.Image")));
            this.closeForm.Location = new System.Drawing.Point(0, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(52, 30);
            this.closeForm.TabIndex = 3;
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(974, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "تسجيل المبيعات وادارتها";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 534);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1217, 30);
            this.panel5.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 51);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1223, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "الاعدادت العامة";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.setPasswordText);
            this.groupBox2.Controls.Add(this.setUserrnameText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(485, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 203);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "االامان";
            // 
            // setPasswordText
            // 
            this.setPasswordText.Location = new System.Drawing.Point(230, 124);
            this.setPasswordText.Name = "setPasswordText";
            this.setPasswordText.Size = new System.Drawing.Size(322, 49);
            this.setPasswordText.TabIndex = 7;
            this.setPasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // setUserrnameText
            // 
            this.setUserrnameText.Location = new System.Drawing.Point(231, 61);
            this.setUserrnameText.Name = "setUserrnameText";
            this.setUserrnameText.Size = new System.Drawing.Size(322, 49);
            this.setUserrnameText.TabIndex = 6;
            this.setUserrnameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 42);
            this.label6.TabIndex = 1;
            this.label6.Text = "كلمة المرور";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 42);
            this.label5.TabIndex = 0;
            this.label5.Text = "اسم المستخدم";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.activateExpireDate);
            this.groupBox1.Controls.Add(this.activateNubmerText);
            this.groupBox1.Controls.Add(this.serialNumberText);
            this.groupBox1.Location = new System.Drawing.Point(485, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 242);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات التفعيل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 42);
            this.label4.TabIndex = 5;
            this.label4.Text = "تاريخ الانتهاء";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "رقم التفعيل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "رقم التسلسلي";
            // 
            // activateExpireDate
            // 
            this.activateExpireDate.Location = new System.Drawing.Point(230, 158);
            this.activateExpireDate.Name = "activateExpireDate";
            this.activateExpireDate.ReadOnly = true;
            this.activateExpireDate.Size = new System.Drawing.Size(322, 49);
            this.activateExpireDate.TabIndex = 2;
            this.activateExpireDate.Text = "5656546";
            this.activateExpireDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // activateNubmerText
            // 
            this.activateNubmerText.Location = new System.Drawing.Point(230, 103);
            this.activateNubmerText.Name = "activateNubmerText";
            this.activateNubmerText.ReadOnly = true;
            this.activateNubmerText.Size = new System.Drawing.Size(322, 49);
            this.activateNubmerText.TabIndex = 1;
            this.activateNubmerText.Text = "565645";
            this.activateNubmerText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serialNumberText
            // 
            this.serialNumberText.Location = new System.Drawing.Point(230, 48);
            this.serialNumberText.Name = "serialNumberText";
            this.serialNumberText.ReadOnly = true;
            this.serialNumberText.Size = new System.Drawing.Size(322, 49);
            this.serialNumberText.TabIndex = 0;
            this.serialNumberText.Text = "54646";
            this.serialNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.saveChanges);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1217, 60);
            this.panel2.TabIndex = 0;
            // 
            // saveChanges
            // 
            this.saveChanges.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveChanges.Image = ((System.Drawing.Image)(resources.GetObject("saveChanges.Image")));
            this.saveChanges.Location = new System.Drawing.Point(1160, 0);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(57, 60);
            this.saveChanges.TabIndex = 3;
            this.toolTip1.SetToolTip(this.saveChanges, "حفط التعديلات");
            this.saveChanges.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1231, 622);
            this.tabControl1.TabIndex = 5;
            // 
            // settingScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1231, 652);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settingScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settingScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox setPasswordText;
        private System.Windows.Forms.TextBox setUserrnameText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox activateExpireDate;
        private System.Windows.Forms.TextBox activateNubmerText;
        private System.Windows.Forms.TextBox serialNumberText;
    }
}