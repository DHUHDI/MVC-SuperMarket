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
    public partial class UpdateSupplier : Form
    {
        string supplierId=null;
        string businessName = null;
        string contacts = null;
        string phone = null;
        string address = null;
        string settlementMethod = null;
        public UpdateSupplier()
        {
            InitializeComponent();

        }


        #region 修改界面
        public UpdateSupplier(SupplierEntity supplierEntity)
        {
            InitializeComponent();
            textBox1_GHSID.Text=supplierEntity.SupplierId;
            textBox2_Shop.Text=supplierEntity.Merchantname;
            textBox3_Name.Text=supplierEntity.Contacts;
            textBox4_Phone.Text=supplierEntity.Phone;
            textBox5_Address.Text=supplierEntity.Address;
            comboBox1_Cost.Text=supplierEntity.Settlement;
        }

        public SupplierEntity SupplierUpdate()
        {
            supplierId = textBox1_GHSID.Text;
            businessName = textBox2_Shop.Text;
            contacts = textBox3_Name.Text;
            phone = textBox4_Phone.Text;
            address = textBox5_Address.Text;
            settlementMethod = comboBox1_Cost.Text;
            SupplierEntity entity = new SupplierEntity(supplierId,businessName,contacts,phone,address,settlementMethod);
            return entity;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupplierEntity entity = SupplierUpdate();
            ISupplierManageController manageController = new SupplierManageControllerImpl();
            bool term = manageController.UpdateSupplierInfo(entity,supplierId);

            if (term == true)
            {
                MessageBox.Show("修改供货商信息成功！");
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
