namespace SalesSystem.forms.extermForms
{
    partial class activateScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(activateScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enterActivate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activateNumberText = new System.Windows.Forms.TextBox();
            this.serialNumberText = new System.Windows.Forms.TextBox();
            this.copySerialNumber = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(743, 30);
            this.panel1.TabIndex = 8;
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
            this.label1.Location = new System.Drawing.Point(486, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "تسجيل المبيعات وادارتها";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.copySerialNumber);
            this.groupBox1.Controls.Add(this.enterActivate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.activateNumberText);
            this.groupBox1.Controls.Add(this.serialNumberText);
            this.groupBox1.Location = new System.Drawing.Point(0, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 275);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تفعيل البرنامج";
            // 
            // enterActivate
            // 
            this.enterActivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterActivate.Location = new System.Drawing.Point(277, 214);
            this.enterActivate.Name = "enterActivate";
            this.enterActivate.Size = new System.Drawing.Size(148, 61);
            this.enterActivate.TabIndex = 5;
            this.enterActivate.Text = "تفعيل";
            this.enterActivate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "رقم التفعيل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "الرقم التسلسلي";
            // 
            // activateNumberText
            // 
            this.activateNumberText.Location = new System.Drawing.Point(180, 144);
            this.activateNumberText.Name = "activateNumberText";
            this.activateNumberText.Size = new System.Drawing.Size(322, 49);
            this.activateNumberText.TabIndex = 1;
            this.activateNumberText.Text = "565645";
            this.activateNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serialNumberText
            // 
            this.serialNumberText.Location = new System.Drawing.Point(180, 76);
            this.serialNumberText.Name = "serialNumberText";
            this.serialNumberText.ReadOnly = true;
            this.serialNumberText.Size = new System.Drawing.Size(322, 49);
            this.serialNumberText.TabIndex = 0;
            this.serialNumberText.Text = "54646";
            this.serialNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // copySerialNumber
            // 
            this.copySerialNumber.Image = ((System.Drawing.Image)(resources.GetObject("copySerialNumber.Image")));
            this.copySerialNumber.Location = new System.Drawing.Point(127, 75);
            this.copySerialNumber.Name = "copySerialNumber";
            this.copySerialNumber.Size = new System.Drawing.Size(47, 50);
            this.copySerialNumber.TabIndex = 6;
            this.toolTip1.SetToolTip(this.copySerialNumber, "تفريغ  الجدول");
            this.copySerialNumber.UseVisualStyleBackColor = true;
            // 
            // activateScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(743, 308);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "activateScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "activateScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enterActivate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox activateNumberText;
        private System.Windows.Forms.TextBox serialNumberText;
        private System.Windows.Forms.Button copySerialNumber;
    }
}