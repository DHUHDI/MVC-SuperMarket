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
    class SupplierManageControllerImpl : ISupplierManageController
    {
        ISupplierManageDataService supplier = new SupplierManageDataServiceImpl();


        public bool DeleteSupplierInfo(string jobnumber)
        {
            bool term = supplier.DeleteInfo(jobnumber);
            return term;
        }

        public bool InsertSupplierInfo(SupplierEntity obj)
        {
            bool term =supplier.InsertInfo(obj);
            return term;
        }

        public void JudgeNull(SupplierEntity obj)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectSupplierInfo(string name)
        {
            DataTable data = supplier.SelectLittleInfo(name);

            return data;
        }

        public DataTable ShowNewTable()
        {
            DataTable data = supplier.AddSelectInfo();

            return data;
        }

        public DataTable ShowTable()
        {
            DataTable data =supplier.SelectAllInfo();

            return data;
        }

        public bool UpdateSupplierInfo(SupplierEntity obj, string jobnumber)
        {
            bool term = supplier.UpdateInfo(obj, jobnumber);
            return term;
        }
    }
}
