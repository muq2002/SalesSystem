using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesSystem.models;

namespace SalesSystem.models
{
    public class Product
    {
        private int Id;
        private string code;
        private string name;
        private double buyingPrice;
        private double sellingPrice;
        private int quanity;

        public Product() { }
        public Product(string productCode, string productName, double productBuyingPrice,
            double productSellingPrice, int productQuanity)
        {

            this.code = productCode;
            this.name = productName;
            this.buyingPrice = productBuyingPrice;
            this.sellingPrice = productSellingPrice;
            this.quanity = productQuanity;
        }
        public Product(int productId, string productCode, string productName, double productBuyingPrice,
            double productSellingPrice, int productQuanity)
        {

            this.Id = productId;
            this.code = productCode;
            this.name = productName;
            this.buyingPrice = productBuyingPrice;
            this.sellingPrice = productSellingPrice;
            this.quanity = productQuanity;
        }




        DatabaseEngine productTable = new DatabaseEngine();
        public DataTable getProductTable() { return productTable.getTable("SELECT * FROM Products"); }

        public void addProduct()
        {
            try
            {
                DateTime registerDate = DateTime.Now;
                productTable.runCommand(@"
                    INSERT INTO Products (CodeProduct, NameProduct, BuyingPrice, SellingPrice, Quanity, RegisterDate)
                    VALUES ('" + this.code + "','" + this.name + "','" + this.buyingPrice.ToString() + "','" + this.sellingPrice.ToString() + "','"
                       + this.quanity.ToString() + "','" + registerDate + "')");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void updateProduct(Product myProduct)
        {
            try
            {
                productTable.runCommand(@"UPDATE Products SET CodeProduct = '" + myProduct.code + "', NameProduct = '"
                    + myProduct.name + "', BuyingPrice='" + myProduct.buyingPrice.ToString() + "', SellingPrice = '"
                    + myProduct.sellingPrice.ToString() + "', Quanity = '" + myProduct.quanity.ToString() + "' WHERE ID=" + myProduct.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void deleteProduct(int productId)
        {
            productTable.runCommand("DELETE FROM Products WHERE ID=" + productId);
        }

        public string getProductPrice(string code) {
            DataTable  dt = productTable.getTable("SELECT * FROM Products WHERE [CodeProduct] = '" + code + "'");
            if (dt.Rows.Count != 0)
                return dt.Rows[0][4].ToString();
            return "";
        }
        public string getProductName(string code)
        {
            DataTable dt = productTable.getTable("SELECT * FROM Products WHERE [CodeProduct] = '" + code + "'");
            if(dt.Rows.Count != 0)
                return dt.Rows[0][2].ToString();
            return "";
        }
    }

}
