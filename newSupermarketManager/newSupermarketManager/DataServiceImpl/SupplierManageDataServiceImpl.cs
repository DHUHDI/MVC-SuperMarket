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
    class SupplierManageDataServiceImpl : ISupplierManageDataService
    {

        //连接数据库对象
        MySqlConnection con = null;
        public DataTable AddSelectInfo()
        {
            DataTable data = null;
            try
            {
                con = Connectionsql.Connection();
                data = SelectMysql.selectnew("select supplierId as '供货商ID'," +
                    "businessName as '商家名称',contacts as '联系人'," +
                    "phone as '电话号码',address as '公司地址'" +
                    ",settlementMethod as '结算方式'" +
                   " from tb_supplier");
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
            bool term = SelectMysql.result("delete from tb_supplier where supplierId='" + jobnumber + "'");
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

        public bool InsertInfo(SupplierEntity obj)
        {
            con = Connectionsql.Connection();
            bool term = SelectMysql.result("insert into  tb_supplier(supplierId,businessName,contacts,phone,address,settlementMethod)" +
                " values(" + "'" + obj.SupplierId + "'" + "," + "'" + obj.Merchantname + "'" + ","
                    + "'" + obj.Contacts + "'" + "," + "'" + obj.Phone + "'" + "," + "'" + obj.Address + "'" + "," + "'" + obj.Settlement+"')");
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
                data = SelectMysql.datatable("select supplierId as '供货商ID'," +
                    "businessName as '商家名称',contacts as '联系人'," +
                    "phone as '电话号码',address as '公司地址'" +
                    ",settlementMethod as '结算方式'" +
                   " from tb_supplier");
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

        public bool SelectInfo(SupplierEntity obj)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectLittleInfo(string name)
        {
            DataTable data = null;
            try
            {
                con = Connectionsql.Connection();
                data = SelectMysql.datatable("select supplierId as '供货商ID'," +
                    "businessName as '商家名称',contacts as '联系人'," +
                    "phone as '电话号码',address as '公司地址'" +
                    ",settlementMethod as '结算方式'" +
                   " from tb_supplier where businessName='%" + name + "%'");
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

        public bool UpdateInfo(SupplierEntity obj, string jobnumber)
        {
            con = Connectionsql.Connection();
            bool term = SelectMysql.result("update tb_supplier set businessName='" + obj.Merchantname+ "'," +
                "contacts='" + obj.Contacts + "',phone='" + obj.Phone + "',address='" + obj.Address + "',settlementMethod=" +
                    "'" + obj.Settlement + "' where supplierId='" + jobnumber + "'");
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
