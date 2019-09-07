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
    class StockManageDataServiceImpl : IStockManageDataService
    {
        MySqlConnection con = null;
        public DataTable AddSelectInfo()
        {
            DataTable data = null;
            try
            {
                con = Connectionsql.Connection();
                data = SelectMysql.selectnew("select commodityId as '商品ID',commodityName as '产品名称',businessName as '商家名称',costPrice as '成本价'" +
                    ",unitPrice as '单价',commodityNumber as '库存量',remarks as '备注'" +
                " from tb_commodityInfo");
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
            bool term = SelectMysql.result("delete from tb_commodityInfo where commodityId='" + jobnumber + "'");
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

        public bool InsertInfo(ProductInfoEntity obj)
        {
            con = Connectionsql.Connection();
            bool term = SelectMysql.result("insert into  tb_commodityInfo(commodityId,commodityName,businessName,costPrice,unitPrice,commodityNumber" +
                ",remarks) values(" + "'" + obj.ProductId + "'" + "," + "'" + obj.Productname + "'" + ","
                    + "'" + obj.Merchantname + "'" + "," + "'" + obj.Costprice + "'" + "," + "'" + obj.Unitprice + "'" + "," + "'" + obj.Merchantinventory +
                    "'" + "," + "'" + obj.Remarks + "')");
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
                data = SelectMysql.selectnew("select commodityId as '商品ID',commodityName as '产品名称',businessName as '商家名称',costPrice as '成本价'" +
                    ",unitPrice as '单价',commodityNumber as '库存量',remarks as '备注'" +
                " from tb_commodityInfo");
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

        public List<string> SelectColumn(string column,string tableName)
        {
            List<string> list = null;
            try
            {
                con = Connectionsql.Connection();
                list = SelectMysql.selectlist("select distinct "+column+" from "+tableName,column);
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

        public bool SelectInfo(ProductInfoEntity obj)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectLittleInfo(string name)
        {
            DataTable data = null;
            try
            {
                con = Connectionsql.Connection();
                data = SelectMysql.datatable("select commodityId as '商品ID',commodityName as '产品名称',businessName as '商家名称',costPrice as '成本价'" +
                    ",unitPrice as '单价',commodityNumber as '库存量',remarks as '备注'" +
                " from tb_commodityInfo where commodityName like  '%" + name + "%'");
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

        public bool UpdateInfo(ProductInfoEntity obj, string jobnumber)
        {
            con = Connectionsql.Connection();
            bool term = SelectMysql.result("update tb_commodityInfo set commodityId='" + obj.ProductId + "'," +
                "commodityName='" + obj.Productname + "',businessName='" + obj.Merchantname + "',costPrice='" + obj.Costprice + "',unitPrice=" +
                    "'" + obj.Unitprice + "',commodityNumber='" + obj.Merchantinventory + "'" +
                    ",remarks='" + obj.Remarks + "' where purchaseId='" + jobnumber + "'");
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
