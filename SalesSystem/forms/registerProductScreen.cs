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
    public partial class registerProductScreen : Form
    {

        #region formSetting
        DatabaseEngine productTable = new DatabaseEngine();
        public registerProductScreen()
        {
            InitializeComponent();
        }

        private void registerProductScreen_Load(object sender, EventArgs e)
        {
            getUpdatesFromRegisterProducts();

            getStyleOfManageProductsTable();

            getStyleOfRegisterProductsTable();
        }

        private void getStyleOfRegisterProductsTable()
        {
            registerProductsTable.Columns[0].ReadOnly = true;
        }

        private void getStyleOfManageProductsTable()
        {
            try
            {
                manageProductsTable.Columns[0].Visible = false;
                manageProductsTable.Columns[3].Width = 180;
                manageProductsTable.Columns[6].Width = 180;

                // Get columns names 
                getColumnsNamesForManagementProductsTable();
            }
            catch (Exception ex) { }


        }


        private void getColumnsNamesForManagementProductsTable()
        {
            manageProductsTable.Columns[1].HeaderText = "كود المنتج";
            manageProductsTable.Columns[2].HeaderText = "اسم المنتج";
            manageProductsTable.Columns[3].HeaderText = "سعر الشراء";
            manageProductsTable.Columns[4].HeaderText = "سعر البيع";
            manageProductsTable.Columns[5].HeaderText = "العدد";
            manageProductsTable.Columns[6].HeaderText = "تاريخ الستجيل";
        }

        private void getUpdatesFromRegisterProducts()
        {
            var dt = productTable.getTable("SELECT * FROM Products ORDER BY ID");
            manageProductsTable.DataSource = dt;
            getStyleOfManageProductsTable();
        }



        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region register products
        #region controlsRegisterTable
        private void addProductsTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (registerProductsTable.Rows.Count == 0) {
                    EmptyRegisterProductsTableMessage();
                    return;
                }

                for (int i = 0; i < registerProductsTable.Rows.Count - 1; i++)
                {
                    DataGridViewRow productRow = registerProductsTable.Rows[i];
                    insertProduct(productRow);
                }
            }
            catch (Exception ex)
            {
                fillDataCorrectlyMessage();
            }
        }

        private void EmptyRegisterProductsTableMessage() {
            otherForms.customMessageBox customBox = new otherForms.customMessageBox
            {
                Message = "الجدول فارغ!"
            };
            customBox.ShowDialog();
        }
        private static void fillDataCorrectlyMessage()
        {
            otherForms.customMessageBox customBox = new otherForms.customMessageBox();
            customBox.Message = "يرجى ملأ البانات بشكل صحيح";
            customBox.ShowDialog();
        }

        private void insertProduct(DataGridViewRow rowProduct)
        {

            Product myProduct = new Product(rowProduct.Cells[1].Value.ToString(),
                rowProduct.Cells[2].Value.ToString(), double.Parse(rowProduct.Cells[3].Value.ToString()),
                double.Parse(rowProduct.Cells[4].Value.ToString()), int.Parse(rowProduct.Cells[5].Value.ToString()));
            myProduct.addProduct();
        }
        private void deleteRowRegisterProductTable_Click(object sender, EventArgs e)
        {
            if (registerProductsTable.Rows.Count == 1 || registerProductsTable.CurrentRow == null)
                return;
            if (!isDeleteItemAgree())
                return;

            int index = registerProductsTable.CurrentRow.Index;
            registerProductsTable.Rows.RemoveAt(index);

        }
        private void registerProductsTable_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            int index = registerProductsTable.CurrentRow.Index;
            registerProductsTable.Rows[index].Cells[0].Value = registerProductsTable.Rows.Count - 1;

        }
        #endregion

        private void registerProductsTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow selectedRow = registerProductsTable.Rows[e.RowIndex];
            DataGridViewColumn selectedColumn = registerProductsTable.Columns[e.ColumnIndex];

            if (e.ColumnIndex == 3)
            {
                string buyingPrice = selectedRow.Cells[3].Value.ToString();
                if (!isNumeric(buyingPrice))
                    selectedRow.Cells[3].Value = "";
            }

            if (e.ColumnIndex == 4)
            {
                string sellingPrice = selectedRow.Cells[4].Value.ToString();
                if (!isNumeric(sellingPrice))
                    selectedRow.Cells[4].Value = "";
            }

            if (e.ColumnIndex == 5)
            {
                string quantiy = selectedRow.Cells[5].Value.ToString();
                if (!isNumeric(quantiy))
                    selectedRow.Cells[5].Value = "";
            }


        }

        #endregion


        #region management products

        List<int> deletedProducts = new List<int>();
        List<int> updatedProducts = new List<int>();

        #region controlsOfManagment Table
        private void refreshManageProductTable_Click(object sender, EventArgs e)
        {
            if (!isRefreshItemAgree())
                return;

            manageProductsTable.DataSource = null;
            getUpdatesFromRegisterProducts();
        }
        private static bool isRefreshItemAgree()
        {
            otherForms.customMessageBox customBox = new otherForms.customMessageBox();
            customBox.Message = "سيؤدي هذا الاجراء الى الغاء جميع التعديلاتك  هل تريد الاستمرار ؟";
            customBox.ShowDialog();
            return customBox.isAgree;
        }
        private void saveChanges_Click(object sender, EventArgs e)
        {
            if (!isSaveAgree())
                return;

            if (deletedProducts.Count != 0)
                deleteProducts();

            if (updatedProducts.Count != 0)
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
            foreach (int index in updatedProducts)
            {
                Product myProduct = new Product(
                    int.Parse(manageProductsTable.Rows[index].Cells[1].Value.ToString()),
                    manageProductsTable.Rows[index].Cells[2].Value.ToString(),
                    manageProductsTable.Rows[index].Cells[3].Value.ToString(),
                    double.Parse(manageProductsTable.Rows[index].Cells[4].Value.ToString()),
                    double.Parse(manageProductsTable.Rows[index].Cells[5].Value.ToString()),
                    int.Parse(manageProductsTable.Rows[index].Cells[6].Value.ToString())
                );
                myProduct.updateProduct(myProduct);
            }

        }

        private void deleteProducts()
        {
            foreach (int productId in deletedProducts)
            {
                Product myProduct = new Product();
                myProduct.deleteProduct(productId);
            }
        }
        private void removeRowManageProductsTable_Click(object sender, EventArgs e)
        {
            if (!isDeleteItemAgree())
                return;

            int productId = int.Parse(manageProductsTable.SelectedRows[0].Cells[1].Value.ToString());
            deletedProducts.Add(productId);
            manageProductsTable.Rows.RemoveAt(manageProductsTable.SelectedRows[0].Index);
        }

        private static bool isDeleteItemAgree()
        {
            otherForms.customMessageBox customBox = new otherForms.customMessageBox();
            customBox.Message = "هل انت متأكد من حذف هذا العنصر ؟";
            customBox.ShowDialog();
            return customBox.isAgree;
        }

        private void clearAllData_Click(object sender, EventArgs e)
        {
            if (isAgreeClearData())
                registerProductsTable.Rows.Clear();
        }

        private static bool isAgreeClearData()
        {
            otherForms.customMessageBox customBox = new otherForms.customMessageBox();
            customBox.Message = "هل انت متأكد من تفريغ الجدول؟";
            customBox.ShowDialog();
            return customBox.isAgree;
        }

        private void searchProducts_Click(object sender, EventArgs e)
        {
            otherForms.searchProducts searchProductsForm = new otherForms.searchProducts();
            searchProductsForm.Show();
        }


        #endregion
        private void manageProductsTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            updatedProducts.Add(index);

            DataGridViewRow selectedRow = manageProductsTable.Rows[e.RowIndex];
            DataGridViewColumn selectedColumn = manageProductsTable.Columns[e.ColumnIndex];

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