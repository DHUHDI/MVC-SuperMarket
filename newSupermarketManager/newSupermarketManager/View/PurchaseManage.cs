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
    public partial class PurchaseManage : Form
    {

        IPurchaseManageController purchase = new PurchaseManageControllerImpl();
        public PurchaseManage()
        {
            InitializeComponent();
            //显示时间
            this.toolStripStatusLabel3.Text = "登录时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            //查询全部职工信息
            DataTable data = purchase.ShowTable();
            this.dataGridView1.DataSource = data;
        }

        //修改进货信息
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(this, "确定要修改此进货信息吗？", "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (this.dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("没有选中进货信息！");
                return;
            }

            PurchaseEntity purchaseEntity = new PurchaseEntity();

            if (dialog == DialogResult.Yes)
            {
                int i = this.dataGridView1.CurrentRow.Index;


                purchaseEntity.PurchaseId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                purchaseEntity.Productname = dataGridView1.Rows[i].Cells[1].Value.ToString();
                purchaseEntity.Purchasenumber = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                purchaseEntity.Costprice = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                purchaseEntity.Total =int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                purchaseEntity.Purchasedate = dataGridView1.Rows[i].Cells[5].Value.ToString();
                purchaseEntity.Experience= dataGridView1.Rows[i].Cells[6].Value.ToString();
                purchaseEntity.Purchasestate=dataGridView1.Rows[i].Cells[7].Value.ToString();
                UpdatePurchase update = new UpdatePurchase(purchaseEntity);
                DialogResult dt = update.ShowDialog();

                if (dt == DialogResult.OK)
                {
                    purchaseEntity = update.PurchaseUpdate();
                    dataGridView1.CurrentRow.Cells[0].Value = purchaseEntity.PurchaseId;
                    dataGridView1.Rows[i].Cells[1].Value = purchaseEntity.Productname;
                    dataGridView1.Rows[i].Cells[2].Value = purchaseEntity.Purchasenumber;
                    dataGridView1.Rows[i].Cells[3].Value = purchaseEntity.Costprice;
                    dataGridView1.Rows[i].Cells[4].Value = purchaseEntity.Total;
                    dataGridView1.Rows[i].Cells[5].Value = purchaseEntity.Purchasedate;
                    dataGridView1.Rows[i].Cells[6].Value = purchaseEntity.Experience;
                    dataGridView1.Rows[i].Cells[7].Value = purchaseEntity.Purchasestate;

                }

            }
            if (purchaseEntity == null)
            {
                MessageBox.Show("未选中进货信息！");
                return;

            }
        }

        //添加进货信息
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            InsertPurchase insert = new InsertPurchase();
            //返回输入框的值
            DialogResult dialog = insert.ShowDialog();


            if (dialog == DialogResult.OK)
            {

                DataTable data = purchase.ShowNewTable();
                this.dataGridView1.DataSource = data;
                if (data == null)
                {
                    MessageBox.Show("此进货信息添加失败，请重新添加！");
                }

            }
        }
        //删除进货信息
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string jobnumber;
            DialogResult dialog = MessageBox.Show(this, "确定要删除此进货信息吗？", "提示",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            bool term = false;
            if (dialog == DialogResult.Yes)
            {
                if (this.dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("没有选中进货信息！");
                    return;
                }
                for (int i = this.dataGridView1.SelectedRows.Count; i > 0; i--)
                {

                    jobnumber = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    if (jobnumber == null)
                    {
                        MessageBox.Show("未选中进货信息！");
                        return;
                    }
                    else
                    {
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[i - 1].Index);

                        term = purchase.DeletePurchaseInfo(jobnumber);
                    }
                }
            }
        }
        //查询进货信息
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DataTable data = purchase.SelectPurchaseInfo(toolStripTextBox1.Text.ToString());
            this.dataGridView1.DataSource = data;
        }
        //刷新
        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = purchase.ShowTable();
            this.dataGridView1.DataSource = data;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
