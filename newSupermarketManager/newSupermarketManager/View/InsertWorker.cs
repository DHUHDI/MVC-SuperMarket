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
    public partial class InsertWorker : Form
    {
        public InsertWorker()
        {
            InitializeComponent();
        }

        private void textBox1_GH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 'r') || (e.KeyChar == 'j') || (e.KeyChar == 'x') || (e.KeyChar == 'k') || (e.KeyChar == (char)Keys.Back));

            //判断是否重复输入点号
            if ((e.KeyChar == 'r') && textBox1_GH.Text.Contains("r"))
            {
                e.Handled = true;
            }

            //判断是否重复输入点号
            if ((e.KeyChar == 'j') && textBox1_GH.Text.Contains("j"))
            {
                e.Handled = true;
            }
            //判断是否重复输入点号
            if ((e.KeyChar == 'k') && textBox1_GH.Text.Contains("k"))
            {
                e.Handled = true;
            }
            //判断是否重复输入点号
            if ((e.KeyChar == 'x') && textBox1_GH.Text.Contains("x"))
            {
                e.Handled = true;
            }
        }

        private void textBox6_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back));
        }

        private void textBox7_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back));
        }

        private void textBox9_SFZH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jobnumber = textBox1_GH.Text;
            string name = textBox2_Name.Text;
            string sex = comboBox1_Sex.Text;
            string workunit = comboBox2_GZDW.Text;
            string birth = dateTimePicker1.Text;
            string password = textBox6_Pass.Text;
            string phone = textBox7_Phone.Text;
            string address = textBox8_Addr.Text;
            string idnumber = textBox9_SFZH.Text;
            string hiredate = dateTimePicker2.Text;

            WorkerEntity worker = new WorkerEntity(jobnumber, password, name, idnumber,sex,address, workunit, phone, birth, hiredate);
            IWorkerManageController manageController= new WorkerManageControllerImpl();
            bool term = manageController.InsertWorkerInfo(worker);

            if (term == true)
            {
                WorkerManage form = new WorkerManage();
                MessageBox.Show("添加职工信息成功！");
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                MessageBox.Show("添加职工信息失败！");
            }
        }
    }
}
