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
    class PurchaseManageControllerImpl : IPurchaseManageController
    {
        IPurchaseManageDataService purchase = new PurchaseManageDataServiceImpl();
        public bool DeletePurchaseInfo(string jobnumber)
        {
            bool term = purchase.DeleteInfo(jobnumber);
            return term;
        }

        public bool InsertPurchaseInfo(PurchaseEntity obj)
        {
            bool term = purchase.InsertInfo(obj);
            return term;
        }

        public void JudgeNull(PurchaseEntity obj)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectPurchaseInfo(string name)
        {
            DataTable data =purchase.SelectLittleInfo(name);

            return data;
        }

        public DataTable ShowNewTable()
        {
            DataTable data = purchase.AddSelectInfo();

            return data;
        }

        public DataTable ShowTable()
        {
            DataTable data = purchase.SelectAllInfo();

            return data;
        }

        public bool UpdatePurchaseInfo(PurchaseEntity obj, string jobnumber)
        {
            bool term = purchase.UpdateInfo(obj, jobnumber);
            return term;
        }
    }
}
