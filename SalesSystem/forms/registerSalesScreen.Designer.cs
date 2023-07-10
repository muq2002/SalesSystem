namespace SalesSystem.forms
{
    partial class registerSalesScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerSalesScreen));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.searchSales = new System.Windows.Forms.Button();
            this.removeRowManageSalesTable = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            this.refreshManageSalesTable = new System.Windows.Forms.Button();
            this.clearAllData = new System.Windows.Forms.Button();
            this.deleteRowRegisterSalesTable = new System.Windows.Forms.Button();
            this.printBill = new System.Windows.Forms.Button();
            this.saveBill = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.manageSalesTable = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.registerSalesTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerBillInformation = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.closeForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageSalesTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerSalesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBillInformation)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchSales
            // 
            this.searchSales.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchSales.Image = ((System.Drawing.Image)(resources.GetObject("searchSales.Image")));
            this.searchSales.Location = new System.Drawing.Point(1011, 0);
            this.searchSales.Name = "searchSales";
            this.searchSales.Size = new System.Drawing.Size(57, 60);
            this.searchSales.TabIndex = 5;
            this.toolTip1.SetToolTip(this.searchSales, "البحث عن منتج");
            this.searchSales.UseVisualStyleBackColor = true;
            this.searchSales.Click += new System.EventHandler(this.searchSales_Click);
            // 
            // removeRowManageSalesTable
            // 
            this.removeRowManageSalesTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.removeRowManageSalesTable.Image = ((System.Drawing.Image)(resources.GetObject("removeRowManageSalesTable.Image")));
            this.removeRowManageSalesTable.Location = new System.Drawing.Point(1068, 0);
            this.removeRowManageSalesTable.Name = "removeRowManageSalesTable";
            this.removeRowManageSalesTable.Size = new System.Drawing.Size(57, 60);
            this.removeRowManageSalesTable.TabIndex = 3;
            this.toolTip1.SetToolTip(this.removeRowManageSalesTable, "حذف المنتج");
            this.removeRowManageSalesTable.UseVisualStyleBackColor = true;
            this.removeRowManageSalesTable.Click += new System.EventHandler(this.removeRowManageSalesTable_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveChanges.Image = ((System.Drawing.Image)(resources.GetObject("saveChanges.Image")));
            this.saveChanges.Location = new System.Drawing.Point(1125, 0);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(57, 60);
            this.saveChanges.TabIndex = 2;
            this.toolTip1.SetToolTip(this.saveChanges, "حفط التعديلات");
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // refreshManageSalesTable
            // 
            this.refreshManageSalesTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.refreshManageSalesTable.Image = ((System.Drawing.Image)(resources.GetObject("refreshManageSalesTable.Image")));
            this.refreshManageSalesTable.Location = new System.Drawing.Point(1182, 0);
            this.refreshManageSalesTable.Name = "refreshManageSalesTable";
            this.refreshManageSalesTable.Size = new System.Drawing.Size(57, 60);
            this.refreshManageSalesTable.TabIndex = 1;
            this.toolTip1.SetToolTip(this.refreshManageSalesTable, "تحديث الجدول");
            this.refreshManageSalesTable.UseVisualStyleBackColor = true;
            this.refreshManageSalesTable.Click += new System.EventHandler(this.refreshManageSalesTable_Click);
            // 
            // clearAllData
            // 
            this.clearAllData.Dock = System.Windows.Forms.DockStyle.Right;
            this.clearAllData.Image = ((System.Drawing.Image)(resources.GetObject("clearAllData.Image")));
            this.clearAllData.Location = new System.Drawing.Point(1182, 0);
            this.clearAllData.Name = "clearAllData";
            this.clearAllData.Size = new System.Drawing.Size(57, 60);
            this.clearAllData.TabIndex = 1;
            this.toolTip1.SetToolTip(this.clearAllData, "تفريغ  الجدول");
            this.clearAllData.UseVisualStyleBackColor = true;
            this.clearAllData.Click += new System.EventHandler(this.clearAllData_Click);
            // 
            // deleteRowRegisterSalesTable
            // 
            this.deleteRowRegisterSalesTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteRowRegisterSalesTable.Image = ((System.Drawing.Image)(resources.GetObject("deleteRowRegisterSalesTable.Image")));
            this.deleteRowRegisterSalesTable.Location = new System.Drawing.Point(1125, 0);
            this.deleteRowRegisterSalesTable.Name = "deleteRowRegisterSalesTable";
            this.deleteRowRegisterSalesTable.Size = new System.Drawing.Size(57, 60);
            this.deleteRowRegisterSalesTable.TabIndex = 2;
            this.toolTip1.SetToolTip(this.deleteRowRegisterSalesTable, "حذف المنتج");
            this.deleteRowRegisterSalesTable.UseVisualStyleBackColor = true;
            this.deleteRowRegisterSalesTable.Click += new System.EventHandler(this.deleteRowRegisterSalesTable_Click);
            // 
            // printBill
            // 
            this.printBill.Dock = System.Windows.Forms.DockStyle.Left;
            this.printBill.Image = ((System.Drawing.Image)(resources.GetObject("printBill.Image")));
            this.printBill.Location = new System.Drawing.Point(0, 0);
            this.printBill.Name = "printBill";
            this.printBill.Size = new System.Drawing.Size(57, 60);
            this.printBill.TabIndex = 3;
            this.toolTip1.SetToolTip(this.printBill, "طباعة فاتورة");
            this.printBill.UseVisualStyleBackColor = true;
            // 
            // saveBill
            // 
            this.saveBill.Dock = System.Windows.Forms.DockStyle.Left;
            this.saveBill.Image = ((System.Drawing.Image)(resources.GetObject("saveBill.Image")));
            this.saveBill.Location = new System.Drawing.Point(57, 0);
            this.saveBill.Name = "saveBill";
            this.saveBill.Size = new System.Drawing.Size(57, 60);
            this.saveBill.TabIndex = 4;
            this.toolTip1.SetToolTip(this.saveBill, "حفط التعديلات");
            this.saveBill.UseVisualStyleBackColor = true;
            this.saveBill.Click += new System.EventHandler(this.addSalesToTable_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 458);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1239, 30);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 458);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1239, 30);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.searchSales);
            this.panel3.Controls.Add(this.removeRowManageSalesTable);
            this.panel3.Controls.Add(this.saveChanges);
            this.panel3.Controls.Add(this.refreshManageSalesTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1239, 60);
            this.panel3.TabIndex = 1;
            // 
            // manageSalesTable
            // 
            this.manageSalesTable.AllowUserToAddRows = false;
            this.manageSalesTable.AllowUserToDeleteRows = false;
            this.manageSalesTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.manageSalesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageSalesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageSalesTable.Location = new System.Drawing.Point(3, 63);
            this.manageSalesTable.Name = "manageSalesTable";
            this.manageSalesTable.RowTemplate.Height = 28;
            this.manageSalesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.manageSalesTable.Size = new System.Drawing.Size(1239, 395);
            this.manageSalesTable.TabIndex = 3;
            this.manageSalesTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.manageSalesTable_CellEndEdit);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.manageSalesTable);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 51);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1245, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ادارة سجل المبيعات";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.saveBill);
            this.panel2.Controls.Add(this.printBill);
            this.panel2.Controls.Add(this.deleteRowRegisterSalesTable);
            this.panel2.Controls.Add(this.clearAllData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1239, 60);
            this.panel2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 51);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1245, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "تسجيل المبيعات";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.registerSalesTable);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel2.Controls.Add(this.registerBillInformation);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1239, 395);
            this.splitContainer1.SplitterDistance = 800;
            this.splitContainer1.TabIndex = 4;
            // 
            // registerSalesTable
            // 
            this.registerSalesTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.registerSalesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registerSalesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column4,
            this.Column7});
            this.registerSalesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerSalesTable.Location = new System.Drawing.Point(0, 0);
            this.registerSalesTable.Name = "registerSalesTable";
            this.registerSalesTable.RowTemplate.Height = 28;
            this.registerSalesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.registerSalesTable.Size = new System.Drawing.Size(800, 395);
            this.registerSalesTable.TabIndex = 3;
            this.registerSalesTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.registerSalesTable_CellEndEdit);
            this.registerSalesTable.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.registerSalesTable_UserAddedRow);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "*";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
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
            this.Column3.ReadOnly = true;
            this.Column3.Width = 260;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "سعر البيع";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "العدد";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "الكلي";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ProductID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // registerBillInformation
            // 
            this.registerBillInformation.AllowUserToAddRows = false;
            this.registerBillInformation.AllowUserToDeleteRows = false;
            this.registerBillInformation.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.registerBillInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registerBillInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9});
            this.registerBillInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerBillInformation.Location = new System.Drawing.Point(0, 0);
            this.registerBillInformation.Name = "registerBillInformation";
            this.registerBillInformation.RowTemplate.Height = 28;
            this.registerBillInformation.Size = new System.Drawing.Size(435, 395);
            this.registerBillInformation.TabIndex = 0;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "الحقل";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "القيمة";
            this.Column9.Name = "Column9";
            this.Column9.Width = 120;
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
            this.tabControl1.Size = new System.Drawing.Size(1253, 546);
            this.tabControl1.TabIndex = 3;
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
            this.label1.Location = new System.Drawing.Point(996, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "تسجيل المبيعات وادارتها";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.closeForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 30);
            this.panel1.TabIndex = 2;
            // 
            // registerSalesScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1253, 576);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registerSalesScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registerSalesScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.registerSalesScreen_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manageSalesTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.registerSalesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBillInformation)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button searchSales;
        private System.Windows.Forms.Button removeRowManageSalesTable;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button refreshManageSalesTable;
        private System.Windows.Forms.Button clearAllData;
        private System.Windows.Forms.Button deleteRowRegisterSalesTable;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView manageSalesTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView registerSalesTable;
        private System.Windows.Forms.DataGridView registerBillInformation;
        private System.Windows.Forms.Button printBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button saveBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}