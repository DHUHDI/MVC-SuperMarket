using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using newSupermarketManager.Controller;
using newSupermarketManager.ControllerIpml;
using newSupermarketManager.Model;

namespace newSupermarketManager.View
{
    public partial class UpdateStock : Form
    {

        public UpdateStock()
        {
            InitializeComponent();
            selectColumn("businessName", "tb_supplier");
            selectColumn("commodityName", "tb_purchase");
        }
        public UpdateStock(ProductInfoEntity productInfoEntity)
        {

            InitializeComponent();
            textBox1_ID.Text = productInfoEntity.ProductId;
            comboBox2.Text = productInfoEntity.Productname;
            comboBox1.Text = productInfoEntity.Merchantname;
            textBox3_DJ.Text = productInfoEntity.Costprice.ToString();
            textBox5_CBJ.Text = productInfoEntity.Unitprice.ToString();
            textBox4_SPKCL.Text = productInfoEntity.Merchantinventory.ToString();
            textBox7_BZ.Text = productInfoEntity.Remarks;
            selectColumn("businessName", "tb_supplier");
            selectColumn("commodityName", "tb_purchase");
        }

        internal ProductInfoEntity StockUpdate()
        {
            string commodityId = textBox1_ID.Text;
            string commodityName = comboBox2.Text;
            string businessName = comboBox1.Text;
            string str = textBox5_CBJ.Text;
            int costPrice = int.Parse(str);
            string str1 = textBox3_DJ.Text;
            int unitPrice = int.Parse(str1);
            string str2 = textBox4_SPKCL.Text;
            int commodityNumber = int.Parse(str2);
            string remarks = textBox7_BZ.Text;
            ProductInfoEntity entity = new ProductInfoEntity(commodityId, commodityName, businessName, costPrice, unitPrice, commodityNumber, remarks);
            return entity;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //添加
        private void button1_Click(object sender, EventArgs e)
        {
            ProductInfoEntity entity = StockUpdate();
            IStockManageController manageController = new StockManageControllerImpl();
            bool term = manageController.UpdateProductInfo(entity, entity.ProductId);

            if (term == true)
            {
                MessageBox.Show("修改库存信息成功！");
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }

        private void textBox1_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 'P' || (e.KeyChar == (char)Keys.Back));

            //判断是否重复输入点号
            if ((e.KeyChar == 'P') && textBox1_ID.Text.Contains("P"))
            {
                e.Handled = true;
            }
        }

        private void textBox3_DJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back));
        }

        private void textBox5_CBJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back));
        }

        private void textBox4_SPKCL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back));
        }

        public void selectColumn(string column, string table)
        {
            IStockManageController stockManageController = new StockManageControllerImpl();
            List<string> list = stockManageController.SelectColumn(column, table);
            for (int i = 0; i < list.Count; i++)
            {
                string str = list[i];
                if (table.Equals("tb_supplier"))
                {
                    this.comboBox1.Items.Add(str);
                }
                else if (table.Equals("tb_purchase"))
                {
                    this.comboBox2.Items.Add(str);
                }
            }
        }
    }
}
