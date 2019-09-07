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
    public partial class InsertSupplier : Form
    {
        public InsertSupplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string supplierId = textBox1_GHSID.Text;
            string businessName = textBox2_Shop.Text;
            string contacts = textBox3_Name.Text;
            string phone = textBox4_Phone.Text;
            string address = textBox5_Address.Text;
            string settlementMethod = comboBox1_Cost.Text;
            SupplierEntity entity = new SupplierEntity(supplierId, businessName, contacts, phone, address, settlementMethod);
            ISupplierManageController manageController = new SupplierManageControllerImpl();

            bool term = manageController.InsertSupplierInfo(entity);
            if (term == true)
            {
                WorkerManage form = new WorkerManage();
                MessageBox.Show("添加供货商信息成功");
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                MessageBox.Show("添加供货商信息失败！");
            }
        }

        private void textBox1_GHSID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 'G')  || (e.KeyChar == (char)Keys.Back));
            //判断是否重复输入点号
            if ((e.KeyChar == 'G') && textBox1_GHSID.Text.Contains("G"))
            {
                e.Handled = true;
            }
        }


        private void textBox4_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
