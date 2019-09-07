using MySql.Data.MySqlClient;
using newSupermarketManager.DataService;
using newSupermarketManager.Model;
using newSupermarketManager.Mysql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newSupermarketManager.DataServiceImpl
{
    class WorkerManageDataImpl : IWorkerManageDataService
    {
        //连接数据库对象
        MySqlConnection con = null;
        public DataTable AddSelectInfo()
        {
            DataTable data = null;
            try
            {
                con = Connectionsql.Connection();
                data = SelectMysql.selectnew("select Gonghao as '工号',Password as '密码',Name as '职工姓名',Shenfenzhenghao as '身份证号',Sex as '性别',Address as '地址',Gongzuodanwei as '工作单位'," +
                "Phone as '联系方式',Birth as '出生日期',Ruyongriqi as '录用日期' from tb_zhigong");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "提示", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }
            return data;
        }
        //删除
        public bool DeleteInfo(string jobnumber)
        {
            con = Connectionsql.Connection();
            bool term = SelectMysql.result("delete from tb_zhigong where Gonghao='" + jobnumber + "'");
            try
            {
                if (term == true)
                {
                    return term;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "提示", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }

            return term;

        }


        public bool InsertInfo(WorkerEntity obj)
        {
            con = Connectionsql.Connection();
            bool term = SelectMysql.result("insert into  tb_zhigong(Gonghao,Password,Name,Shenfenzhenghao,Sex,Address" +
                ",Gongzuodanwei,Phone,Birth,Ruyongriqi) values(" + "'" + obj.Jobnumber + "'" + "," + "'" + obj.Password + "'" + ","
                    + "'" + obj.Name + "'" + "," + "'" + obj.Idnumber + "'" + "," + "'" + obj.Sex + "'" + "," + "'" + obj.Address +
                    "'" + "," + "'" + obj.Workunit + "'" + "," + "'" + obj.Phone + "'" + "," + "'" + obj.Birth + "'" + "," + "'" + obj.Hiredate + "'" + ")");
            try
            {
                if (term == true)
                {
                    return term;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "提示", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }

            return term;
        }

        public DataTable SelectAllInfo()
        {

            DataTable data = null;
            try
            {
                con = Connectionsql.Connection();
                data = SelectMysql.datatable("select Gonghao as '工号',Password as '密码',Name as '职工姓名',Shenfenzhenghao as '身份证号',Sex as '性别',Address as '地址',Gongzuodanwei as '工作单位'," +
                "Phone as '联系方式',Birth as '出生日期',Ruyongriqi as '录用日期' from tb_zhigong");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "提示", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }
            return data;
        }

        public bool SelectInfo(WorkerEntity obj)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectLittleInfo(string name)
        {
            DataTable data = null;
            try
            {
                con = Connectionsql.Connection();
                data = SelectMysql.datatable("select Gonghao as '工号',Password as '密码',Name as '职工姓名',Shenfenzhenghao as '身份证号',Sex as '性别',Address as '地址',Gongzuodanwei as '工作单位'," +
               "Phone as '联系方式',Birth as '出生日期',Ruyongriqi as '录用日期' from tb_zhigong Where Name='%" + name + "%'");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "提示", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }
            return data;
        }

        public bool UpdateInfo(WorkerEntity obj,string jobnumber)
        {
            con = Connectionsql.Connection();
            bool term = SelectMysql.result("update tb_zhigong set Password='" + obj.Password + "'," +
                "Name='" + obj.Name + "',Shenfenzhenghao='" + obj.Idnumber + "',Sex='" + obj.Sex + "',Address=" +
                    "'" + obj.Address + "',Phone='" + obj.Phone + "'" +
                    ",Birth='" + obj.Birth + "',Ruyongriqi='" + obj.Hiredate + "'where Gonghao='" + jobnumber + "'");
            try
            {
                if (term == true)
                {
                    return term;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "提示", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }

            return term;
        }
    }
}
