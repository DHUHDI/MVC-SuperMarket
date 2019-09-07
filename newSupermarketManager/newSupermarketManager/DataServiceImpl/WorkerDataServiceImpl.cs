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
    class WorkerDataServiceImpl : IWorkerDataService
    {

        //连接数据库对象
        MySqlConnection con=null;
        public DataTable AddSelectInfo()
        {
            throw new NotImplementedException();
        }

        public bool DeleteInfo(string jobnumber)
        {
            throw new NotImplementedException();
        }

        //注册
        public bool InsertInfo(WorkerEntity obj)
        {
           
            con = Connectionsql.Connection();
            bool term = SelectMysql.result("insert into  tb_zhigong(Gonghao,Password,Gongzuodanwei) values(" + "'" + obj.Jobnumber + "'" + "," + "'" + obj.Password + "'" + ","
                    + "'" + obj.Workunit + "')");
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
            throw new NotImplementedException();
        }

        //登录
        public bool SelectInfo(WorkerEntity obj)
        {
            bool term = false;
            con = Connectionsql.Connection();
            MySqlDataReader reader = SelectMysql.reader("select Gonghao,Password,Gongzuodanwei from tb_zhigong");
            try
            {
                while (reader.Read())
                {
                    if ((obj.Jobnumber == reader.GetString("Gonghao")) && (obj.Password == reader.GetString("Password")) && (obj.Workunit == reader.GetString("Gongzuodanwei")))
                    {
                        term = true;
                    }
                   
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

        public DataTable SelectLittleInfo(string name)
        {
            throw new NotImplementedException();
        }

        public bool SelectUniqueInfo(WorkerEntity obj)
        {

            con = Connectionsql.Connection();
            bool term = SelectMysql.result("select Gonghao from tb_zhigong where Gonghao='"+obj.Jobnumber+"'");
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

        public bool UpdateInfo(WorkerEntity obj,string jobnumber)
        {
            throw new NotImplementedException();
        }
    }
}
