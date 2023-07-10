using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesSystem.forms;

namespace SalesSystem
{
    public partial class homeScreen : Form
    {

        public homeScreen()
        {
            InitializeComponent();
    
        }
    

        private void openRegisterProductsScreen_Click(object sender, EventArgs e)
        {
            registerProductScreen myScreen = new registerProductScreen();
            myScreen.ShowDialog();
        }

        private void openRegisterSalesScreen_Click(object sender, EventArgs e)
        {
            registerSalesScreen myScreen = new registerSalesScreen();
            myScreen.ShowDialog();
        }

        private void openSettingSetting_Click(object sender, EventArgs e)
        {
            settingScreen myScreen = new settingScreen();
            myScreen.ShowDialog();
        }

        private void homeScreen_ResizeEnd(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            forms.extermForms.activateScreen myForm = new forms.extermForms.activateScreen();
            myForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            forms.extermForms.loginScreen myForm = new forms.extermForms.loginScreen();
            myForm.Show();
        }
    }
}
