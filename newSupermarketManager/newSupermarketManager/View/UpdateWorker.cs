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
    public partial class UpdateWorker : Form
    {
        string jobnumber = null;
        string name = null;
        string sex = null;
        string workunit = null;
        string birth = null;
        string password = null;
        string phone = null;
        string address = null;
        string idnumber = null;
        string hiredate = null;

        public UpdateWorker()
        {
            InitializeComponent();
        }
        public UpdateWorker(WorkerEntity worker)
        {
            InitializeComponent();
            textBox1_GH.Text = worker.Jobnumber;

            textBox6_Pass.Text = worker.Password;
            textBox2_Name.Text=worker.Name;
            comboBox1_Sex.Text=worker.Sex;
            textBox1.Text=worker.Workunit;
            dateTimePicker1.Text=worker.Birth;
            textBox7_Phone.Text=worker.Phone;
            textBox8_Addr.Text=worker.Address;
            textBox9_SFZH.Text=worker.Idnumber;
            dateTimePicker2.Text=worker.Hiredate;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            WorkerEntity entity = Worker();
            IWorkerManageController manageController = new WorkerManageControllerImpl();
            bool term = manageController.UpdateWokerInfo(entity,jobnumber);
            if (term == true)
            {
                MessageBox.Show("修改职工信息成功！");
                this.DialogResult = DialogResult.OK;
                this.Hide();

            }

        }
        public WorkerEntity Worker()
        {
            jobnumber = textBox1_GH.Text;
            name = textBox2_Name.Text;
            sex = comboBox1_Sex.Text;
            workunit = textBox1.Text;
            birth = dateTimePicker1.Text;
            password = textBox6_Pass.Text;
            phone = textBox7_Phone.Text;
            address = textBox8_Addr.Text;
            idnumber = textBox9_SFZH.Text;
            hiredate = dateTimePicker2.Text;
            WorkerEntity entity = new WorkerEntity(jobnumber, password, name, idnumber, sex, address, workunit, phone, birth, hiredate);
            return entity;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
