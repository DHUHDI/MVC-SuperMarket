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
    public partial class WorkerManage : Form
    {
        //职工控制器对象
        IWorkerManageController worker = new WorkerManageControllerImpl();


        //供货商控制器对象
        ISupplierManageController supplier = new SupplierManageControllerImpl();
        public WorkerManage()
        {
            InitializeComponent();
            //显示时间
            this.toolStripStatusLabel3.Text = "登录时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            //查询全部职工信息
            DataTable data = worker.ShowTable();
            this.dataGridView1.DataSource = data;
            //查询全部供货商信息
            DataTable supplierdata = supplier.ShowTable();
            this.dataGridView2.DataSource = data;
        }

        #region 职工信息管理
        //添加
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            InsertWorker insert = new InsertWorker();
            //返回输入框的值
            DialogResult dialog = insert.ShowDialog();


            if (dialog == DialogResult.OK)
            {

                DataTable data = worker.ShowNewTable();
                this.dataGridView1.DataSource = data;
                if (data == null)
                {
                    MessageBox.Show("此职工信息添加失败，请重新添加！");
                }

            }
        }

        //删除
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         //修改
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(this, "确定要修改此职工信息吗？", "提示",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (this.dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("没有选中职工！");
                return;
            }

            WorkerEntity workerEntity = new WorkerEntity();

            if (dialog == DialogResult.Yes)
            {
                int i = this.dataGridView1.CurrentRow.Index;


                workerEntity.Jobnumber= dataGridView1.CurrentRow.Cells[0].Value.ToString();
                workerEntity.Password = dataGridView1.Rows[i].Cells[1].Value.ToString();
                workerEntity.Name = dataGridView1.Rows[i].Cells[2].Value.ToString();
                workerEntity.Idnumber = dataGridView1.Rows[i].Cells[3].Value.ToString();
                workerEntity.Sex = dataGridView1.Rows[i].Cells[4].Value.ToString();
                workerEntity.Address = dataGridView1.Rows[i].Cells[5].Value.ToString();
                workerEntity.Workunit = dataGridView1.Rows[i].Cells[6].Value.ToString();
                workerEntity.Phone = dataGridView1.Rows[i].Cells[7].Value.ToString();
                workerEntity.Hiredate = dataGridView1.Rows[i].Cells[8].Value.ToString();
                workerEntity.Birth = dataGridView1.Rows[i].Cells[9].Value.ToString();

                UpdateWorker update = new UpdateWorker(workerEntity);
                DialogResult dt = update.ShowDialog();
              
                if (dt == DialogResult.OK)
                {
                    workerEntity = update.Worker();
                    dataGridView1.CurrentRow.Cells[0].Value = workerEntity.Jobnumber;
                    dataGridView1.Rows[i].Cells[1].Value = workerEntity.Password;
                    dataGridView1.Rows[i].Cells[2].Value = workerEntity.Name;
                    dataGridView1.Rows[i].Cells[3].Value = workerEntity.Idnumber;
                    dataGridView1.Rows[i].Cells[4].Value = workerEntity.Sex ;
                    dataGridView1.Rows[i].Cells[5].Value = workerEntity.Address;
                    dataGridView1.Rows[i].Cells[6].Value = workerEntity.Workunit ;
                    dataGridView1.Rows[i].Cells[7].Value = workerEntity.Phone;
                    dataGridView1.Rows[i].Cells[8].Value = workerEntity.Hiredate;
                    dataGridView1.Rows[i].Cells[9].Value = workerEntity.Birth;

                }

            }
            if (workerEntity== null)
            {
                MessageBox.Show("未选中职工！");
                return;

            }
        }

        //删除
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string jobnumber;
            DialogResult dialog = MessageBox.Show(this, "确定要删除此职工信息吗？", "提示",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            bool term = false;
            if (dialog == DialogResult.Yes)
            {
                if (this.dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("没有选中职工！");
                    return;
                }
                for (int i = this.dataGridView1.SelectedRows.Count; i > 0; i--)
                {

                   jobnumber = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    if (jobnumber == null)
                    {
                        MessageBox.Show("未选中职工！");
                        return;
                    }
                    else
                    {
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[i - 1].Index);
                        
                        term =worker.DeleteWorkerInfo(jobnumber);
                    }
                }
            }

            if (term == true)
            {
                MessageBox.Show("此职工信息已被删除！");
            }
            else
            {
                MessageBox.Show("此职工信息删除失败！");
            }
        }


        //查询
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //查询全部职工信息
            DataTable data = worker.SelectWorkerInfo(toolStripTextBox1.Text.ToString());
            this.dataGridView1.DataSource = data;
        }


        //刷新
        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //查询全部职工信息
            DataTable data = worker.ShowTable();
            this.dataGridView1.DataSource = data;
        }

        #endregion

        #region 供货商管理


        //添加供货商信息
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            InsertSupplier insertSupplier = new InsertSupplier();
            //返回输入框的值
            DialogResult dialog = insertSupplier.ShowDialog();


            if (dialog == DialogResult.OK)
            {

                DataTable data = supplier.ShowNewTable();
                this.dataGridView2.DataSource = data;
                if (data == null)
                {
                    MessageBox.Show("此职工信息添加失败，请重新添加！");
                }

            }
        }


        //修改供货商信息

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(this, "确定要修改此供货商信息吗？", "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (this.dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("没有选中供货商！");
                return;
            }

            SupplierEntity supplierEntity = new SupplierEntity();

            if (dialog == DialogResult.Yes)
            {
                int i = this.dataGridView1.CurrentRow.Index;


                supplierEntity.SupplierId = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                supplierEntity.Merchantname = dataGridView2.Rows[i].Cells[1].Value.ToString();
                supplierEntity.Contacts = dataGridView2.Rows[i].Cells[2].Value.ToString();
                supplierEntity.Phone = dataGridView2.Rows[i].Cells[3].Value.ToString();
                supplierEntity.Address = dataGridView2.Rows[i].Cells[4].Value.ToString();
                supplierEntity.Settlement = dataGridView2.Rows[i].Cells[5].Value.ToString();

                UpdateSupplier update = new UpdateSupplier(supplierEntity);
                DialogResult dt = update.ShowDialog();

                if (dt == DialogResult.OK)
                {
                    supplierEntity = update.SupplierUpdate();
                    dataGridView1.CurrentRow.Cells[0].Value = supplierEntity.SupplierId;
                    dataGridView1.Rows[i].Cells[1].Value = supplierEntity.Merchantname;
                    dataGridView1.Rows[i].Cells[2].Value = supplierEntity.Contacts;
                    dataGridView1.Rows[i].Cells[3].Value = supplierEntity.Phone;
                    dataGridView1.Rows[i].Cells[4].Value = supplierEntity.Address;
                    dataGridView1.Rows[i].Cells[5].Value = supplierEntity.Settlement;

                }

            }
            if (supplierEntity == null)
            {
                MessageBox.Show("未选中供货商！");
                return;

            }
        }

        //删除供货商信息
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            string jobnumber;
            DialogResult dialog = MessageBox.Show(this, "确定要删除此供货商信息吗？", "提示",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            bool term = false;
            if (dialog == DialogResult.Yes)
            {
                if (this.dataGridView2.SelectedRows.Count == 0)
                {
                    MessageBox.Show("没有选中供货商！");
                    return;
                }
                for (int i = this.dataGridView2.SelectedRows.Count; i > 0; i--)
                {

                    jobnumber = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    if (jobnumber == null)
                    {
                        MessageBox.Show("未选中供货商！");
                        return;
                    }
                    else
                    {
                        dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[i - 1].Index);

                        term = supplier.DeleteSupplierInfo(jobnumber);
                    }
                }
            }

            if (term == true)
            {
                MessageBox.Show("此供货商信息已被删除！");
            }
            else
            {
                MessageBox.Show("此供货商信息删除失败！");
            }
        }
        //查询供货商信息
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            DataTable data = supplier.SelectSupplierInfo(toolStripTextBox2.Text.ToString());
            this.dataGridView2.DataSource = data;
        }

        private void 刷新ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataTable data = supplier.ShowTable();
            this.dataGridView2.DataSource = data;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
