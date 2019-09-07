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
    public partial class Register : Form
    {
        ILoginController register = null;
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register = new LoginControllerImpl();
            string jobnumber = textBox1.Text;
            string password = textBox2.Text;
            string workunit = textBox3.Text;
            WorkerEntity obj = new WorkerEntity(jobnumber, password, workunit);
            register.JudgeNull(obj);
            bool term =false;//判断是否添加成功
            bool judge = false;//判断是否重复添加
            if (jobnumber != "" && password != "" && workunit != "")
            {
               term = register.InsertDatabase(obj);//判断是否添加成功
               judge = register.Register(obj);//判断是否重复添加
            }

            if (judge == true)
            {
                MessageBox.Show("用户已注册！");
            }
            else
            {
                if (term == true)
                {
                    MessageBox.Show("注册成功！");
                    Login login = new Login();
                    this.Hide();
                    login.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login sale = new Login();
            this.Hide();
            sale.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 'S') || (e.KeyChar == (char)Keys.Back));
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
