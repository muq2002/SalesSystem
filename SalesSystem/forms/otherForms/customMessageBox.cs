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
    public partial class customMessageBox : Form
    {
        public customMessageBox()
        {
            InitializeComponent();
        }
        public string Message = "";
        public bool isAgree = false;
        private void customMessageBox_Load(object sender, EventArgs e)
        {
            textMessage.Text = Message;
        }
        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            isAgree = true;
            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            isAgree = false;
            this.Close();
        }

        private void agreeButton_Click(object sender, EventArgs e)
        {
            isAgree = true;
        }


    }
}
