using newSupermarketManager.ControllerBase;
using newSupermarketManager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSupermarketManager.Controller
{
    interface ISupplierManageController:IController<SupplierEntity>
    {
        DataTable ShowTable();
        DataTable ShowNewTable();

        //添加供货商信息
        bool InsertSupplierInfo(SupplierEntity obj);
        //删除供货商信息
        bool DeleteSupplierInfo(string jobnumber);

        //修改供货商信息
        bool UpdateSupplierInfo(SupplierEntity obj, string jobnumber);

        //查询供货商信息
        DataTable SelectSupplierInfo(string name);
    }
}
