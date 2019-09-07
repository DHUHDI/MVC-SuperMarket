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
    public partial class InsertSale : Form
    {
        public InsertSale()
        {
            InitializeComponent();
            selectColumn("commodityName", "tb_purchase");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string saleId = textBox1_XSDID.Text;
            string commodityName = comboBox1_SPMC.Text;
            string saleDate = dateTimePicker1.Text;
            string str = textBox4_XSSL.Text;
            int saleNumber = int.Parse(str);
            string payMethod = comboBox2_ZFFS.Text;
            string workerName = comboBox1.Text;
            string Gonghao = textBox7_GH.Text;
            SaleEntity entity = new SaleEntity(saleId, commodityName, saleDate, saleNumber, payMethod, workerName, Gonghao);
            ISaleManageController saleManageController = new SaleManageControllerImpl();

            bool term = saleManageController.InsertSaleInfo(entity);
            if (term == true)
            {
                SalerManage form = new SalerManage();
                MessageBox.Show("添加库存信息成功");
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                MessageBox.Show("添加库存信息失败！");
            }
        }

        private void textBox1_XSDID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 'X' || (e.KeyChar == (char)Keys.Back));

            //判断是否重复输入点号
            if ((e.KeyChar == 'X') && textBox1_XSDID.Text.Contains("X"))
            {
                e.Handled = true;
            }
        }

        private void textBox4_XSSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back));
        }

        public void selectColumn(string column, string table)
        {
            ISaleManageController saleManageController = new SaleManageControllerImpl();
            List<string> list = saleManageController.SelectColumn(column, table);
            for (int i = 0; i < list.Count; i++)
            {
                string str = list[i];
                this.comboBox1_SPMC.Items.Add(str);
               
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
