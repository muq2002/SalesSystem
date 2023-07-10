namespace SalesSystem.forms
{
    partial class registerProductScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerProductScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.registerProductsTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteRowRegisterProductTable = new System.Windows.Forms.Button();
            this.clearAllData = new System.Windows.Forms.Button();
            this.addProductsTable = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.manageProductsTable = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.searchProducts = new System.Windows.Forms.Button();
            this.removeRowManageProductsTable = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            this.refreshManageProductTable = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerProductsTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageProductsTable)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1275, 30);
            this.panel1.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(1019, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "تسجيل المنتجات وادارتها";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1275, 602);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.registerProductsTable);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 51);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1267, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "تسجيل المنتجات";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 514);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1261, 30);
            this.panel5.TabIndex = 3;
            // 
            // registerProductsTable
            // 
            this.registerProductsTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.registerProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registerProductsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.registerProductsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerProductsTable.Location = new System.Drawing.Point(3, 53);
            this.registerProductsTable.Name = "registerProductsTable";
            this.registerProductsTable.RowTemplate.Height = 28;
            this.registerProductsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.registerProductsTable.Size = new System.Drawing.Size(1261, 491);
            this.registerProductsTable.TabIndex = 2;
            this.registerProductsTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.registerProductsTable_CellEndEdit);
            this.registerProductsTable.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.registerProductsTable_UserAddedRow);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "*";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "كود المنتج";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "اسم المنتج";
            this.Column3.Name = "Column3";
            this.Column3.Width = 260;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "سعر الشراء";
            this.Column4.Name = "Column4";
            this.Column4.Width = 160;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "سعر البيع";
            this.Column5.Name = "Column5";
            this.Column5.Width = 160;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "العدد";
            this.Column6.Name = "Column6";
            this.Column6.Width = 120;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteRowRegisterProductTable);
            this.panel2.Controls.Add(this.clearAllData);
            this.panel2.Controls.Add(this.addProductsTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 50);
            this.panel2.TabIndex = 0;
            // 
            // deleteRowRegisterProductTable
            // 
            this.deleteRowRegisterProductTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteRowRegisterProductTable.Image = ((System.Drawing.Image)(resources.GetObject("deleteRowRegisterProductTable.Image")));
            this.deleteRowRegisterProductTable.Location = new System.Drawing.Point(1090, 0);
            this.deleteRowRegisterProductTable.Name = "deleteRowRegisterProductTable";
            this.deleteRowRegisterProductTable.Size = new System.Drawing.Size(57, 50);
            this.deleteRowRegisterProductTable.TabIndex = 2;
            this.toolTip1.SetToolTip(this.deleteRowRegisterProductTable, "حذف المنتج");
            this.deleteRowRegisterProductTable.UseVisualStyleBackColor = true;
            this.deleteRowRegisterProductTable.Click += new System.EventHandler(this.deleteRowRegisterProductTable_Click);
            // 
            // clearAllData
            // 
            this.clearAllData.Dock = System.Windows.Forms.DockStyle.Right;
            this.clearAllData.Image = ((System.Drawing.Image)(resources.GetObject("clearAllData.Image")));
            this.clearAllData.Location = new System.Drawing.Point(1147, 0);
            this.clearAllData.Name = "clearAllData";
            this.clearAllData.Size = new System.Drawing.Size(57, 50);
            this.clearAllData.TabIndex = 1;
            this.toolTip1.SetToolTip(this.clearAllData, "تفريغ  الجدول");
            this.clearAllData.UseVisualStyleBackColor = true;
            this.clearAllData.Click += new System.EventHandler(this.clearAllData_Click);
            // 
            // addProductsTable
            // 
            this.addProductsTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.addProductsTable.Image = ((System.Drawing.Image)(resources.GetObject("addProductsTable.Image")));
            this.addProductsTable.Location = new System.Drawing.Point(1204, 0);
            this.addProductsTable.Name = "addProductsTable";
            this.addProductsTable.Size = new System.Drawing.Size(57, 50);
            this.addProductsTable.TabIndex = 0;
            this.toolTip1.SetToolTip(this.addProductsTable, "اضافة المنتجات");
            this.addProductsTable.UseVisualStyleBackColor = true;
            this.addProductsTable.Click += new System.EventHandler(this.addProductsTable_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.manageProductsTable);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 51);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1267, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ادارة سجل المنتجات";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // manageProductsTable
            // 
            this.manageProductsTable.AllowUserToAddRows = false;
            this.manageProductsTable.AllowUserToDeleteRows = false;
            this.manageProductsTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.manageProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageProductsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageProductsTable.Location = new System.Drawing.Point(3, 53);
            this.manageProductsTable.Name = "manageProductsTable";
            this.manageProductsTable.RowTemplate.Height = 28;
            this.manageProductsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.manageProductsTable.Size = new System.Drawing.Size(1261, 461);
            this.manageProductsTable.TabIndex = 3;
            this.manageProductsTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.manageProductsTable_CellEndEdit);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 514);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1261, 30);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.searchProducts);
            this.panel3.Controls.Add(this.removeRowManageProductsTable);
            this.panel3.Controls.Add(this.saveChanges);
            this.panel3.Controls.Add(this.refreshManageProductTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1261, 50);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 50);
            this.button1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button1, "تصفية عرض البيانات");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // searchProducts
            // 
            this.searchProducts.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchProducts.Image = ((System.Drawing.Image)(resources.GetObject("searchProducts.Image")));
            this.searchProducts.Location = new System.Drawing.Point(1033, 0);
            this.searchProducts.Name = "searchProducts";
            this.searchProducts.Size = new System.Drawing.Size(57, 50);
            this.searchProducts.TabIndex = 5;
            this.toolTip1.SetToolTip(this.searchProducts, "البحث عن منتج");
            this.searchProducts.UseVisualStyleBackColor = true;
            this.searchProducts.Click += new System.EventHandler(this.searchProducts_Click);
            // 
            // removeRowManageProductsTable
            // 
            this.removeRowManageProductsTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.removeRowManageProductsTable.Image = ((System.Drawing.Image)(resources.GetObject("removeRowManageProductsTable.Image")));
            this.removeRowManageProductsTable.Location = new System.Drawing.Point(1090, 0);
            this.removeRowManageProductsTable.Name = "removeRowManageProductsTable";
            this.removeRowManageProductsTable.Size = new System.Drawing.Size(57, 50);
            this.removeRowManageProductsTable.TabIndex = 3;
            this.toolTip1.SetToolTip(this.removeRowManageProductsTable, "حذف المنتج");
            this.removeRowManageProductsTable.UseVisualStyleBackColor = true;
            this.removeRowManageProductsTable.Click += new System.EventHandler(this.removeRowManageProductsTable_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveChanges.Image = ((System.Drawing.Image)(resources.GetObject("saveChanges.Image")));
            this.saveChanges.Location = new System.Drawing.Point(1147, 0);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(57, 50);
            this.saveChanges.TabIndex = 2;
            this.toolTip1.SetToolTip(this.saveChanges, "حفط التعديلات");
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // refreshManageProductTable
            // 
            this.refreshManageProductTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.refreshManageProductTable.Image = ((System.Drawing.Image)(resources.GetObject("refreshManageProductTable.Image")));
            this.refreshManageProductTable.Location = new System.Drawing.Point(1204, 0);
            this.refreshManageProductTable.Name = "refreshManageProductTable";
            this.refreshManageProductTable.Size = new System.Drawing.Size(57, 50);
            this.refreshManageProductTable.TabIndex = 1;
            this.toolTip1.SetToolTip(this.refreshManageProductTable, "تحديث الجدول");
            this.refreshManageProductTable.UseVisualStyleBackColor = true;
            this.refreshManageProductTable.Click += new System.EventHandler(this.refreshManageProductTable_Click);
            // 
            // registerProductScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1275, 632);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "registerProductScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registerProductScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.registerProductScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.registerProductsTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manageProductsTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView registerProductsTable;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button addProductsTable;
        private System.Windows.Forms.Button searchProducts;
        private System.Windows.Forms.Button removeRowManageProductsTable;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button refreshManageProductTable;
        private System.Windows.Forms.Button clearAllData;
        private System.Windows.Forms.Button deleteRowRegisterProductTable;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button closeForm;
        public System.Windows.Forms.DataGridView manageProductsTable;
    }
}