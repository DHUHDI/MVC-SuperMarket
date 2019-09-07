using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSupermarketManager.Model
{
    /**
     * 职工信息实体
     * */
   public  class WorkerEntity
    {
        private string jobnumber;//工号
        private string password;//密码
        private string name;//姓名
        private string idnumber;//身份证号
        private string sex;//性别
        private string address;//地址
        private string workunit;//工作单位
        private string phone;//电话号
        private string birth;//出生日期
        private string hiredate;//录用日期

        public WorkerEntity()
        {
        }

        public WorkerEntity(string jobnumber, string password, string workunit)
        {
            this.jobnumber = jobnumber;
            this.password = password;
            this.workunit = workunit;
        }

        public WorkerEntity(string jobnumber, string password, string name, string idnumber, string  sex, string address, string workunit, string phone, string birth, string hiredate)
        {
            this.jobnumber = jobnumber;
            this.password = password;
            this.name = name;
            this.idnumber = idnumber;
            this.Sex = sex;
            this.address = address;
            this.workunit = workunit;
            this.phone = phone;
            this.birth = birth;
            this.hiredate = hiredate;
        }

        public string Jobnumber { get => jobnumber; set => jobnumber = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Idnumber { get => idnumber; set => idnumber = value; }
       
        public string Address { get => address; set => address = value; }
        public string Workunit { get => workunit; set => workunit = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Birth { get => birth; set => birth = value; }
        public string Hiredate { get => hiredate; set => hiredate = value; }
        public string Sex { get => sex; set => sex = value; }
    }
}
