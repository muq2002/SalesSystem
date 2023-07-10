using SalesSystem.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesSystem.forms.otherForms
{
    public partial class invoiceTemplete : Form
    {
        DatabaseEngine productTable = new DatabaseEngine();
        public invoiceTemplete()
        {
            InitializeComponent();
        }

        private void getUpdatesFromRegisterProducts()
        {
            var dt = productTable.getTable("SELECT * FROM Products ORDER BY ID");
            dataGridView1.DataSource = dt;
            //getStyleOfManageProductsTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getUpdatesFromRegisterProducts();
        }

        void headerOfInvoice(string shopName, int orderID, string orderDate) { }
        void bodyOfInvoice() { }
        void footerOfInvoice(double totalPrice, double totalPayOff, double demandPrice) { }
    }
}
