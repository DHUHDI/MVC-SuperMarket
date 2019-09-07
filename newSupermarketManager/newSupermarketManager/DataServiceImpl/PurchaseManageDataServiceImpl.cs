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
    class PurchaseManageDataServiceImpl : IPurchaseManageDataService
    {

        MySqlConnection con = null;
        public DataTable AddSelectInfo()
        {
            DataTable data = null;
            try
            {
                con = Connectionsql.Connection();
                data = SelectMysql.selectnew("select purchaseId as '进货ID',commodityName as '产品名称',purchaseNumber as '进货数量',costPrice as '成本价'" +
                    ",total as '总额',purchaseDate as '进货日期',handler as '经手人'," +
                "purchaseStatus as '进货状态' from tb_purchase");
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
            bool term = SelectMysql.result("delete from tb_purchase where purchaseId='" + jobnumber + "'");
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

        public bool InsertInfo(PurchaseEntity obj)
        {
            con = Connectionsql.Connection();
            bool term = SelectMysql.result("insert into  tb_purchase(purchaseId,commodityName,purchaseNumber,costPrice,total,purchaseDate" +
                ",handler,purchaseStatus) values(" + "'" + obj.PurchaseId + "'" + "," + "'" + obj.Productname + "'" + ","
                    + "'" + obj.Purchasenumber + "'" + "," + "'" + obj.Costprice + "'" + "," + "'" + obj.Total + "'" + "," + "'" + obj.Purchasedate +
                    "'" + "," + "'" + obj.Experience + "'" + "," + "'" + obj.Purchasestate+ "')");
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
                data = SelectMysql.datatable("select purchaseId as '进货ID',commodityName as '产品名称',purchaseNumber as '进货数量',costPrice as '成本价'" +
                    ",total as '总额',purchaseDate as '进货日期',handler as '经手人'," +
                "purchaseStatus as '进货状态' from tb_purchase");
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

        public bool SelectInfo(PurchaseEntity obj)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectLittleInfo(string name)
        {
            DataTable data = null;
            try
            {
                con = Connectionsql.Connection();
                data = SelectMysql.datatable("select purchaseId as '进货ID',commodityName as '产品名称',purchaseNumber as '进货数量',costPrice as '成本价'" +
                    ",total as '总额',purchaseDate as '进货日期',handler as '经手人'," +
                "purchaseStatus as '进货状态' from tb_purchase where commodityName like  '%" + name + "%'");
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

        public bool UpdateInfo(PurchaseEntity obj, string jobnumber)
        {
            con = Connectionsql.Connection();
            bool term = SelectMysql.result("update tb_purchase set purchaseId='" + obj.PurchaseId + "'," +
                "commodityName='" + obj.Productname + "',purchaseNumber='" + obj.Purchasenumber + "',costPrice='" + obj.Costprice + "',total=" +
                    "'" + obj.Total + "',purchaseDate='" + obj.Purchasedate + "'" +
                    ",handler='" + obj.Experience + "',purchaseStatus='" + obj.Purchasestate + "' where purchaseId='" + jobnumber + "'");
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
