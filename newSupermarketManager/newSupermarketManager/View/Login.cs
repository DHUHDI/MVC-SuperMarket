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
    public partial class Login : Form
    {
        ILoginController login = null;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = new LoginControllerImpl();
            string jobnumber = textBox1.Text;
            string password = textBox2.Text;
            string workunit = comboBox1.Text;

            WorkerEntity obj = new WorkerEntity(jobnumber, password, workunit);
            SalerManage saler = new SalerManage(obj);
            login.JudgeNull(obj);

            bool term = login.VisitDatabase(obj);

            if (term == true)
            {
                login.JumpShow(obj);
                this.Hide();
                MessageBox.Show("登录成功");
            }
            else
            {
                MessageBox.Show("没有此用户！请重新输入！");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 'r') || (e.KeyChar == 'j') || (e.KeyChar == 'x') || (e.KeyChar == 'k') || (e.KeyChar == 'S') || (e.KeyChar == (char)Keys.Back));

            //判断是否重复输入点号
            if ((e.KeyChar == 'r') && textBox1.Text.Contains("r"))
            {
                e.Handled = true;
            }

            //判断是否重复输入点号
            if ((e.KeyChar == 'j') && textBox1.Text.Contains("j"))
            {
                e.Handled = true;
            }
            //判断是否重复输入点号
            if ((e.KeyChar == 'k') && textBox1.Text.Contains("k"))
            {
                e.Handled = true;
            }
            //判断是否重复输入点号
            if ((e.KeyChar == 'x') && textBox1.Text.Contains("x"))
            {
                e.Handled = true;
            }
            //判断是否重复输入点号
            if ((e.KeyChar == 'S') && textBox1.Text.Contains("S"))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back));
        }
    }
}
