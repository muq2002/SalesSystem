using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesSystem.models;

namespace SalesSystem.forms
{
    public partial class registerSalesScreen : Form
    {
        Product myProduct = new Product();
        public registerSalesScreen()
        {
            InitializeComponent();
        }

        #region Form Setting
        DatabaseEngine salesTable = new DatabaseEngine();
        private void registerSalesScreen_Load(object sender, EventArgs e)
        {
            getUpdatesFromRegisterSales();

            getStyleOfmanageSalesTable();

            getStyleOfRegisterProductsTable();
            getStyleOfregisterBillInformation();
        }


        private void getStyleOfRegisterProductsTable()
        {
            registerSalesTable.Columns[0].ReadOnly = true;
        }

        private void getStyleOfmanageSalesTable()
        {
            try
            {
                manageSalesTable.Columns[0].ReadOnly = true;
                manageSalesTable.Columns[1].Visible = false;
                manageSalesTable.Columns[7].Width = 180;
            }
            catch (Exception ex)
            {
            }


        }
        private void getStyleOfregisterBillInformation()
        {
            registerBillInformation.Rows.Add("اسم العميل");
            registerBillInformation.Rows.Add("مبلغ الفاتورة");
            registerBillInformation.Rows.Add("مبلغ الخصم");
            registerBillInformation.Rows.Add("مبلغ الكلي");

        }
        private void getUpdatesFromRegisterSales()
        {
            var dt = salesTable.getTable("SELECT * FROM Sales ORDER BY ID");
            manageSalesTable.DataSource = dt;
            getStyleOfmanageSalesTable();
        }
        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region register sales
        private void registerSalesTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = registerSalesTable.Rows[e.RowIndex];
            DataGridViewColumn selectedColumn = registerSalesTable.Columns[e.ColumnIndex];

            if (e.ColumnIndex == 1 )
            {
                if (selectedRow.Cells[1].Value == null)
                    return;
                string code = selectedRow.Cells[1].Value.ToString();
                selectedRow.Cells[2].Value = myProduct.getProductName(code);
                selectedRow.Cells[3].Value = myProduct.getProductPrice(code);
                if (selectedRow.Cells[4].Value == null)
                    selectedRow.Cells[4].Value = 1;
                selectedRow.Cells[5].Value = selectedRow.Cells[3].Value;

            }

            if (e.ColumnIndex == 4)
            {
                if (selectedRow.Cells[4].Value == null)
                    return;
                string quantiy = selectedRow.Cells[4].Value.ToString();
                if (!isNumeric(quantiy))
                {
                    selectedRow.Cells[4].Value = "";

                }
                else
                {
                    selectedRow.Cells[5].Value = int.Parse(selectedRow.Cells[4].Value.ToString()) * int.Parse(selectedRow.Cells[3].Value.ToString());
                }

            }

        }

        private void registerSalesTable_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

            registerBillInformation.Rows[1].Cells[1].Value = calculateBillInformation();
            calculatePayOff();

        }

        private void calculatePayOff()
        {
            if (registerBillInformation.Rows[2].Cells[1].Value == null)
                registerBillInformation.Rows[2].Cells[1].Value = 0;
            registerBillInformation.Rows[3].Cells[1].Value = calculateBillInformation() - double.Parse(registerBillInformation.Rows[2].Cells[1].Value.ToString());
        }

        private double calculateBillInformation()
        {
            double totalPrice = 0;
            for (int i = 0; i < registerSalesTable.Rows.Count - 2; i++)
            {
                if (registerSalesTable.Rows[i].Cells[5].Value.ToString() != "")
                    totalPrice += double.Parse(registerSalesTable.Rows[i].Cells[5].Value.ToString());
            }
            return totalPrice;
        }

        #region controls

        private void addSalesToTable_Click(object sender, EventArgs e)
        {


        }

        private void clearAllData_Click(object sender, EventArgs e)
        {
            registerSalesTable.Rows.Clear();
        }

        private void deleteRowRegisterSalesTable_Click(object sender, EventArgs e)
        {
            if (registerSalesTable.Rows.Count == 1 || registerSalesTable.CurrentRow == null)
                return;
            if (!isDeleteItemAgree())
                return;

            int index = registerSalesTable.CurrentRow.Index;
            if(index == registerSalesTable.Rows.Count - 2)
                registerSalesTable.Rows.RemoveAt(index);
        }

        private static bool isDeleteItemAgree()
        {
            otherForms.customMessageBox customBox = new otherForms.customMessageBox();
            customBox.Message = "هل انت متأكد من حذف هذا العنصر ؟";
            customBox.ShowDialog();
            return customBox.isAgree;
        }

        #endregion


        #endregion

        #region manage sales
        List<int> deletedSales = new List<int>();
        List<int> updatedSales = new List<int>();
        private void manageSalesTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            updatedSales.Add(index);

            DataGridViewRow selectedRow = manageSalesTable.Rows[e.RowIndex];
            DataGridViewColumn selectedColumn = manageSalesTable.Columns[e.ColumnIndex];

            if (e.ColumnIndex == 4)
            {
                string buyingPrice = selectedRow.Cells[4].Value.ToString();
                if (!isNumeric(buyingPrice))
                    selectedRow.Cells[4].Value = "";
            }

            if (e.ColumnIndex == 5)
            {
                string sellingPrice = selectedRow.Cells[5].Value.ToString();
                if (!isNumeric(sellingPrice))
                    selectedRow.Cells[5].Value = "";
            }

            if (e.ColumnIndex == 6)
            {
                string quantiy = selectedRow.Cells[6].Value.ToString();
                if (!isNumeric(quantiy))
                    selectedRow.Cells[6].Value = "";
            }

        }
        private void refreshManageSalesTable_Click(object sender, EventArgs e)
        {
            if (!isRefreshItemAgree())
                return;

            manageSalesTable.DataSource = null;
            getUpdatesFromRegisterSales();
        }
        private static bool isRefreshItemAgree()
        {
            otherForms.customMessageBox customBox = new otherForms.customMessageBox();
            customBox.Message = "سيؤدي هذا الاجراء الى الغاء جميع التعديلاتك";
            customBox.ShowDialog();
            return customBox.isAgree;
        }
        private void saveChanges_Click(object sender, EventArgs e)
        {
            if (!isSaveAgree())
                return;

            if (deletedSales.Count != 0)
                deleteProducts();

            if (updatedSales.Count != 0)
                updateItems();

        }
        private static bool isSaveAgree()
        {
            otherForms.customMessageBox customBox = new otherForms.customMessageBox();
            customBox.Message = "هل انت متأكد من  حفظ التعدبلات؟";
            customBox.ShowDialog();
            return customBox.isAgree;
        }

        private void updateItems()
        {
            foreach (int index in updatedSales)
            {
                Product myProduct = new Product(
                    int.Parse(manageSalesTable.Rows[index].Cells[1].Value.ToString()),
                    manageSalesTable.Rows[index].Cells[2].Value.ToString(),
                    manageSalesTable.Rows[index].Cells[3].Value.ToString(),
                    double.Parse(manageSalesTable.Rows[index].Cells[4].Value.ToString()),
                    double.Parse(manageSalesTable.Rows[index].Cells[5].Value.ToString()),
                    int.Parse(manageSalesTable.Rows[index].Cells[6].Value.ToString())
                );
                myProduct.updateProduct(myProduct);
            }

        }

        private void deleteProducts()
        {
            foreach (int productId in deletedSales)
            {
                Product myProduct = new Product();
                myProduct.deleteProduct(productId);
            }
        }

        private void removeRowManageSalesTable_Click(object sender, EventArgs e)
        {
            if (!isDeleteItemAgree())
                return;

            int productId = int.Parse(manageSalesTable.SelectedRows[0].Cells[1].Value.ToString());
            deletedSales.Add(productId);
            manageSalesTable.Rows.RemoveAt(manageSalesTable.SelectedRows[0].Index);
        }

        private void searchSales_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region ohterFunction
        private static bool isNumeric(string text)
        {
            int number;
            return int.TryParse(text, out number);
        }






        #endregion

        
    }
}
