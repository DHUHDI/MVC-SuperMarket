using newSupermarketManager.Controller;
using newSupermarketManager.ControllerIpml;
using newSupermarketManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newSupermarketManager.View
{
    public partial class InsertPurchase : Form
    {
        public InsertPurchase()
        {
            InitializeComponent();
        }

        private void textBox5_JHID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 'J') || (e.KeyChar == (char)Keys.Back));
            //判断是否重复输入点号
            if ((e.KeyChar == 'J') && textBox5_JHID.Text.Contains("J"))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string purchaseId = textBox5_JHID.Text;
            string commodityName = textBox6_SPMC.Text;
            string purchaseNumber = textBox8_JHSL.Text;
            int number = int.Parse(purchaseNumber);
            string costPrice = textBox7_CBJ.Text;
            int price = int.Parse(costPrice);
            string total=textBox1_ZE.Text;
            int pay = int.Parse(total);
            string purchaseDate = dateTimePicker1.Text;
            string handler = textBox3_JSR.Text;
            string purchaseStatus = comboBox1_JHZT.Text;

            PurchaseEntity entity = new PurchaseEntity(purchaseId, commodityName, number, price, pay, purchaseDate, handler, purchaseStatus);
            IPurchaseManageController manageController = new PurchaseManageControllerImpl();

            bool term = manageController.InsertPurchaseInfo(entity);
            if (term == true)
            {
                PurchaseManage form = new PurchaseManage();
                MessageBox.Show("添加进货信息成功");
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                MessageBox.Show("添加进货信息失败！");
            }
       }

        private void textBox7_CBJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back));
        }

        private void textBox8_JHSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            double cbj = Convert.ToDouble(textBox7_CBJ.Text);
            double jhsl = Convert.ToDouble(textBox8_JHSL.Text);
            string str = (cbj * jhsl).ToString();
            this.textBox1_ZE.Text = str;
        }
    }
}
