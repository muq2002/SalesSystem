namespace SalesSystem.forms.otherForms
{
    partial class searchProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchProducts));
            this.label1 = new System.Windows.Forms.Label();
            this.exitBTN = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.searchWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchCategories = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitBTN)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "تسجيل المنتجات وادارتها : البحث عن المنتج";
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
            this.panel1.Size = new System.Drawing.Size(436, 30);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 398);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.searchWord);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.searchCategories);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ادوات البحث";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "كلمة البحث";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(165, 330);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(108, 45);
            this.search.TabIndex = 5;
            this.search.Text = "بحث";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchWord
            // 
            this.searchWord.Location = new System.Drawing.Point(32, 178);
            this.searchWord.Multiline = true;
            this.searchWord.Name = "searchWord";
            this.searchWord.Size = new System.Drawing.Size(344, 134);
            this.searchWord.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "البحث عن";
            // 
            // searchCategories
            // 
            this.searchCategories.FormattingEnabled = true;
            this.searchCategories.Items.AddRange(new object[] {
            "كود المنتج",
            "اسم المنتج",
            "سعر الشراء",
            "سعر البيع",
            "العدد",
            "تاريخ التسجيل"});
            this.searchCategories.Location = new System.Drawing.Point(32, 79);
            this.searchCategories.Name = "searchCategories";
            this.searchCategories.Size = new System.Drawing.Size(344, 50);
            this.searchCategories.TabIndex = 2;
            this.searchCategories.Text = "كود المنتج";
            // 
            // searchProducts
            // 
            this.AcceptButton = this.search;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(436, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "searchProducts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchProducts";
            ((System.ComponentModel.ISupportInitialize)(this.exitBTN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox exitBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchCategories;
        private System.Windows.Forms.Label label3;
    }
}