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
    class StockManageControllerImpl : IStockManageController
    {
        IStockManageDataService stock = new StockManageDataServiceImpl();
        public bool DeleteProductInfo(string jobnumber)
        {
            bool term = stock.DeleteInfo(jobnumber);
            return term;
        }

        public bool InsertProductInfo(ProductInfoEntity obj)
        {
            bool term = stock.InsertInfo(obj);
            return term;
        }

        public void JudgeNull(ProductInfoEntity obj)
        {
            throw new NotImplementedException();
        }

        public List<string> SelectColumn(string column, string tableName)
        {
            List<string> list = stock.SelectColumn(column, tableName);
            return list;
        }

        public DataTable SelectProductInfo(string name)
        {
            DataTable data = stock.SelectLittleInfo(name);

            return data;
        }

        public DataTable ShowNewTable()
        {
            DataTable data = stock.AddSelectInfo();

            return data;
        }

        public DataTable ShowTable()
        {
            DataTable data = stock.SelectAllInfo();

            return data;
        }

        public bool UpdateProductInfo(ProductInfoEntity obj, string jobnumber)
        {
            bool term = stock.UpdateInfo(obj, jobnumber);
            return term;
        }
    }
}
