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
    class SaleManageDataServiceImpl : ISaleManageDataService
    {
        MySqlConnection con = null;
        public DataTable AddSelectInfo()
        {
            DataTable data = null;
            try
            {
                con = Connectionsql.Connection();
                data = SelectMysql.selectnew("select saleId as '销售ID',commodityName as '产品名称',saleDate as '销售日期',saleNumber as '销售数量'" +
                    ",payMethod as '支付方式',workerName as '销售员姓名',Gonghao as '工号'" +
                " from tb_sale");
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

        public bool DeleteInfo(string jobnumber)
        {
            con = Connectionsql.Connection();
            bool term = SelectMysql.result("delete from tb_sale where saleId='" + jobnumber + "'");
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

        public bool InsertInfo(SaleEntity obj)
        {
            con = Connectionsql.Connection();
            bool term = SelectMysql.result("insert into  tb_sale(saleId,commodityName,saleDate,saleNumber,payMethod,workerName" +
                ",Gonghao) values(" + "'" + obj.SalesrecordsId + "'" + "," + "'" + obj.Productname + "'" + ","
                    + "'" + obj.Saledate + "'" + "," + "'" + obj.Salenumber+ "'" + "," + "'" + obj.Paymethod + "'" + "," + "'" + obj.Workername +
                    "'" + "," + "'" + obj.Jobnumber + "')");
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
                data = SelectMysql.selectnew("select saleId as '销售ID',commodityName as '产品名称',saleDate as '销售日期',saleNumber as '销售数量'" +
                    ",payMethod as '支付方式',workerName as '销售员姓名',Gonghao as '工号'" +
                " from tb_sale");
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

        public List<string> SelectColumn(string column, string tableName)
        {
            List<string> list = null;
            try
            {
                con = Connectionsql.Connection();
                list = SelectMysql.selectlist("select distinct " + column + " from " + tableName, column);
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "提示", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }
            return list;
        }

        public bool SelectInfo(SaleEntity obj)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectLittleInfo(string name)
        {
            DataTable data = null;
            try
            {
                con = Connectionsql.Connection();
                data = SelectMysql.datatable("select saleId as '销售ID',commodityName as '产品名称',saleDate as '销售日期',saleNumber as '销售数量'" +
                    ",payMethod as '支付方式',workerName as '销售员姓名',Gonghao as '工号'" +
                " from tb_sale where commodityName like  '%" + name + "%'");
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

        public bool UpdateInfo(SaleEntity obj, string jobnumber)
        {
            con = Connectionsql.Connection();
            bool term = SelectMysql.result("update tb_sale set saleId='" + obj.SalesrecordsId+ "'," +
                "commodityName='" + obj.Productname + "',saleDate='" + obj.Saledate+ "',saleNumber='" + obj.Salenumber + "',payMethod=" +
                    "'" + obj.Paymethod + "',workerName='" + obj.Workername + "'" +
                    ",Gonghao='" + obj.Jobnumber + "' where saleId='" + jobnumber + "'");
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
