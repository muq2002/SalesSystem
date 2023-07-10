using System;
using System.Windows.Forms;
using SalesSystem.models;
namespace SalesSystem.forms.otherForms
{
    public partial class searchProducts : Form
    {
        public searchProducts()
        {
            InitializeComponent();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DatabaseEngine productTable = new DatabaseEngine();
        private void search_Click(object sender, EventArgs e)
        {

            MessageBox.Show(searchCategories.SelectedIndex.ToString());
            if(searchCategories.SelectedIndex == 0)
                queryOfProductCode(searchWord.Text);
            if(searchCategories.SelectedIndex == 1)
                queryOfProductName(searchWord.Text);

            if (searchCategories.SelectedIndex == 2)
                queryOfProductBuyingPrice(searchWord.Text);
            if (searchCategories.SelectedIndex == 3)
                queryOfProductSellingPrice(searchWord.Text);

            if (searchCategories.SelectedIndex == 4)
                queryOfProductQuanity(searchWord.Text);
            if (searchCategories.SelectedIndex == 5)
                queryOfProductRegisterDate(searchWord.Text);


        }

        private void queryOfProductCode(string searchWord)
        {
            string searchQuery = "SELECT * FROM Products WHERE [CodeProduct] LIKE '%" + searchWord + "%';";
            var dt = productTable.getTable(searchQuery);
            registerProductScreen myForm = new registerProductScreen();
            //myForm.manageProductsTable.Columns[0].Width = 300;
            myForm.manageProductsTable.DataSource = null;
            myForm.manageProductsTable.DataSource = dt;
            
        }
        private void queryOfProductName(string searchWord)
        {
            string searchQuery = "SELECT * FROM Products WHERE [NameProduct] LIKE '%" + searchWord + "%';";
            var dt = productTable.getTable(searchQuery);
            //registerProductScreen.manageProductsTable.DataSource = dt;
        }
        private void queryOfProductBuyingPrice(string searchWord)
        {
            string searchQuery = "SELECT * FROM Products WHERE [BuyingPrice] LIKE '%" + searchWord + "%';";
            var dt = productTable.getTable(searchQuery);
            //registerProductScreen.manageProductsTable.DataSource = dt;
        }
        private void queryOfProductSellingPrice(string searchWord)
        {
            string searchQuery = "SELECT * FROM Products WHERE [SellingPrice] LIKE '%" + searchWord + "%';";
            var dt = productTable.getTable(searchQuery);
            //registerProductScreen.manageProductsTable.DataSource = dt;
        }
        private void queryOfProductQuanity(string searchWord)
        {
            string searchQuery = "SELECT * FROM Products WHERE [Quanity] LIKE '%" + searchWord + "%';";
            var dt = productTable.getTable(searchQuery);
            //registerProductScreen.manageProductsTable.DataSource = dt;
        }
        private void queryOfProductRegisterDate(string searchWord)
        {
            string searchQuery = "SELECT * FROM Products WHERE [RegisterDate] LIKE '%" + searchWord + "%';";
            var dt = productTable.getTable(searchQuery);
            //registerProductScreen.manageProductsTable.DataSource = dt;
        }
    }
}
