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
    public partial class UpdatePurchase : Form
    {
        string purchaseId = null;
        string commodityName = null;
        string purchaseNumber = null;
        string costPrice = null;
        string total = null;
        string purchaseDate = null;
        string handler = null;
        string purchaseStatus = null;
        public UpdatePurchase()
        {
            InitializeComponent();
        }

        public UpdatePurchase(PurchaseEntity purchaseEntity)
        {
            InitializeComponent();
            textBox5_JHID.Text = purchaseEntity.PurchaseId;
            textBox6_SPMC.Text = purchaseEntity.Productname;
            textBox8_JHSL.Text = purchaseEntity.Purchasenumber.ToString();
            textBox7_CBJ.Text = purchaseEntity.Costprice.ToString();
            textBox1_ZE.Text = purchaseEntity.Total.ToString();
            dateTimePicker1.Text =purchaseEntity.Purchasedate;
            textBox3_JSR.Text = purchaseEntity.Experience;
            comboBox1_JHZT.Text = purchaseEntity.Purchasestate;
        }

        public PurchaseEntity PurchaseUpdate()
        {
            purchaseId = textBox5_JHID.Text;
            commodityName = textBox6_SPMC.Text;
            purchaseNumber = textBox8_JHSL.Text;
            int number = int.Parse(purchaseNumber);
            costPrice = textBox7_CBJ.Text;
            int price = int.Parse(costPrice);
            total = textBox1_ZE.Text;
            int pay = int.Parse(total);
            purchaseDate = dateTimePicker1.Text;
            handler = textBox3_JSR.Text;
            purchaseStatus = comboBox1_JHZT.Text;
            PurchaseEntity entity = new PurchaseEntity(purchaseId, commodityName, number, price, pay, purchaseDate, handler, purchaseStatus);
            return entity;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PurchaseEntity entity = PurchaseUpdate();
            IPurchaseManageController manageController = new PurchaseManageControllerImpl();
            bool term = manageController.UpdatePurchaseInfo(entity, purchaseId);

            if (term == true)
            {
                MessageBox.Show("修改进货信息成功！");
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
