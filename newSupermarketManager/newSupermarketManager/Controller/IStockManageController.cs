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
    interface IStockManageController:IController<ProductInfoEntity>
    {

        DataTable ShowTable();
        DataTable ShowNewTable();

        //添加信息
        bool InsertProductInfo(ProductInfoEntity obj);
        //删除信息
        bool DeleteProductInfo(string jobnumber);

        //修改信息
        bool UpdateProductInfo(ProductInfoEntity obj, string jobnumber);

        //查询信息
        DataTable SelectProductInfo(string name);

        //查询单独列
        List<string> SelectColumn(string column, string tableName);
    }
}
