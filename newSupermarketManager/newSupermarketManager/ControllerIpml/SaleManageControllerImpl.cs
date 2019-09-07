using newSupermarketManager.Controller;
using newSupermarketManager.DataService;
using newSupermarketManager.DataServiceImpl;
using newSupermarketManager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSupermarketManager.ControllerIpml
{
    class SaleManageControllerImpl : ISaleManageController
    {
        ISaleManageDataService sale = new SaleManageDataServiceImpl();
        public bool DeleteSaleInfo(string jobnumber)
        {
            bool term = sale.DeleteInfo(jobnumber);
            return term;
        }

        public bool InsertSaleInfo(SaleEntity obj)
        {
            bool term = sale.InsertInfo(obj);
            return term;
        }

        public void JudgeNull(SaleEntity obj)
        {
            throw new NotImplementedException();
        }

        public List<string> SelectColumn(string column, string tableName)
        {
            List<string> list = sale.SelectColumn(column, tableName);
            return list;
        }

        public DataTable SelectSaleInfo(string name)
        {
            DataTable data = sale.SelectLittleInfo(name);

            return data;
        }

        public DataTable ShowNewTable()
        {
            DataTable data = sale.AddSelectInfo();

            return data;
        }

        public DataTable ShowTable()
        {
            DataTable data = sale.SelectAllInfo();

            return data;
        }

        public bool UpdateSaleInfo(SaleEntity obj, string jobnumber)
        {
            bool term = sale.UpdateInfo(obj, jobnumber);
            return term;
        }
    }
}
