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
    public partial class SalerManage : Form
    {
        private WorkerEntity obj;
        ISaleManageController saler = new SaleManageControllerImpl();
        public SalerManage()
        {
            InitializeComponent();

            //显示时间
            this.toolStripStatusLabel3.Text = "登录时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        public SalerManage(WorkerEntity obj)
        {
            InitializeComponent();
            this.obj = obj;//显示时间
            this.toolStripStatusLabel3.Text = "登录时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            //查询全部销售信息
            toolStripTextBox1.Text = obj.Name;
            DataTable data = saler.SelectSaleInfo(obj.Idnumber);
            this.dataGridView1.DataSource = data;
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //查询全部销售信息
            toolStripTextBox1.Text = obj.Name;
            DataTable data = saler.SelectSaleInfo(obj.Idnumber);
            this.dataGridView1.DataSource = data;

        }

        private void 销售记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertSale insert = new InsertSale();
            //返回输入框的值
            DialogResult dialog = insert.ShowDialog();


            if (dialog == DialogResult.OK)
            {

                DataTable data = saler.ShowNewTable();
                this.dataGridView1.DataSource = data;
                if (data == null)
                {
                    MessageBox.Show("此销售信息添加失败，请重新添加！");
                }

            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
