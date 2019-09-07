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
    interface ISaleManageController:IController<SaleEntity>
    {
        DataTable ShowTable();
        DataTable ShowNewTable();

        //添加信息
        bool InsertSaleInfo(SaleEntity obj);
        //删除信息
        bool DeleteSaleInfo(string jobnumber);

        //修改信息
        bool UpdateSaleInfo(SaleEntity obj, string jobnumber);

        //查询信息
        DataTable SelectSaleInfo(string name);

        //查询单独列
        List<string> SelectColumn(string column, string tableName);
    }
}
