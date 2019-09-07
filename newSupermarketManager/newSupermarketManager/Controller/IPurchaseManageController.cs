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
    interface IPurchaseManageController:IController<PurchaseEntity>
    {
        DataTable ShowTable();
        DataTable ShowNewTable();

        //添加进货信息
        bool InsertPurchaseInfo(PurchaseEntity obj);
        //删除进货信息
        bool DeletePurchaseInfo(string jobnumber);

        //修改进货信息
        bool UpdatePurchaseInfo(PurchaseEntity obj, string jobnumber);

        //查询进货信息
        DataTable SelectPurchaseInfo(string name);
    }
}
