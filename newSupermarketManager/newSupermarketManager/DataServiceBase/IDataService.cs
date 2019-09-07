using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSupermarketManager.DataServiceBase
{
    interface IDataService<T>
    {
        //查询
        bool SelectInfo(T obj);

        //添加
        bool InsertInfo(T obj);

        //删除
        bool DeleteInfo(string jobnumber);

        //修改
        bool UpdateInfo(T obj,string jobnumber);

        //查询全表
        DataTable SelectAllInfo();

        //查询特定值
        DataTable SelectLittleInfo(string name);

        //添加数据并查询结果
        DataTable AddSelectInfo();
    }
}
