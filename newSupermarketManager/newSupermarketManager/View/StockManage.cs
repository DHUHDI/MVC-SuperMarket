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
    public partial class StockManage : Form
    {
        IStockManageController stock = new StockManageControllerImpl();
        public StockManage()
        {
            InitializeComponent();

            //显示时间
            this.toolStripStatusLabel3.Text = "登录时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            //查询全部库存信息
            DataTable data = stock.ShowTable();
            this.dataGridView1.DataSource = data;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //添加库存信息
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            InsertStock insert = new InsertStock();
            //返回输入框的值
            DialogResult dialog = insert.ShowDialog();


            if (dialog == DialogResult.OK)
            {

                DataTable data = stock.ShowNewTable();
                this.dataGridView1.DataSource = data;
                if (data == null)
                {
                    MessageBox.Show("此库存信息添加失败，请重新添加！");
                }

            }
        }
        //刷新
        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = stock.ShowTable();
            this.dataGridView1.DataSource = data;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string jobnumber;
            DialogResult dialog = MessageBox.Show(this, "确定要删除此库存信息吗？", "提示",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            bool term = false;
            if (dialog == DialogResult.Yes)
            {
                if (this.dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("没有选中库存信息！");
                    return;
                }
                for (int i = this.dataGridView1.SelectedRows.Count; i > 0; i--)
                {

                    jobnumber = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    if (jobnumber == null)
                    {
                        MessageBox.Show("未选中库存信息！");
                        return;
                    }
                    else
                    {
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[i - 1].Index);

                        term = stock.DeleteProductInfo(jobnumber);
                    }
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DataTable data = stock.SelectProductInfo(toolStripTextBox1.Text.ToString());
            this.dataGridView1.DataSource = data;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(this, "确定要修改此库存信息吗？", "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (this.dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("没有选中库存信息！");
                return;
            }

            ProductInfoEntity productInfoEntity = new ProductInfoEntity();

            if (dialog == DialogResult.Yes)
            {
                int i = this.dataGridView1.CurrentRow.Index;


                productInfoEntity.ProductId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                productInfoEntity.Productname = dataGridView1.Rows[i].Cells[1].Value.ToString();
                productInfoEntity.Merchantname = dataGridView1.Rows[i].Cells[2].Value.ToString();
                productInfoEntity.Costprice = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                productInfoEntity.Unitprice = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                productInfoEntity.Merchantinventory = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                productInfoEntity.Remarks = dataGridView1.Rows[i].Cells[6].Value.ToString();
        
                UpdateStock update = new UpdateStock(productInfoEntity);
                DialogResult dt = update.ShowDialog();

                if (dt == DialogResult.OK)
                {
                    productInfoEntity = update.StockUpdate();
                    dataGridView1.CurrentRow.Cells[0].Value = productInfoEntity.ProductId;
                    dataGridView1.Rows[i].Cells[1].Value = productInfoEntity.Productname;
                    dataGridView1.Rows[i].Cells[2].Value = productInfoEntity.Merchantname;
                    dataGridView1.Rows[i].Cells[3].Value = productInfoEntity.Costprice;
                    dataGridView1.Rows[i].Cells[4].Value = productInfoEntity.Unitprice;
                    dataGridView1.Rows[i].Cells[5].Value = productInfoEntity.Merchantinventory;
                    dataGridView1.Rows[i].Cells[6].Value = productInfoEntity.Remarks;
                 
                }

            }
            if (productInfoEntity == null)
            {
                MessageBox.Show("未选中库存信息！");
                return;

            }
        }
    }
}
