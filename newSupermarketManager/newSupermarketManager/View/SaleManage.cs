using newSupermarketManager.Controller;
using newSupermarketManager.ControllerIpml;
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
    public partial class SaleManage : Form
    {
        ISaleManageController sale = new SaleManageControllerImpl();
        public SaleManage()
        {
            InitializeComponent();
            //显示时间
            this.toolStripStatusLabel3.Text = "登录时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            //查询全部职工信息
            DataTable data = sale.ShowTable();
            this.dataGridView1.DataSource = data;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //查询
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DataTable data = sale.SelectSaleInfo(toolStripTextBox1.Text.ToString());
            this.dataGridView1.DataSource = data;
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = sale.ShowTable();
            this.dataGridView1.DataSource = data;
        }
    }
}
