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
    interface IWorkerManageController:IController<WorkerEntity>
    {
        DataTable ShowTable();
        DataTable ShowNewTable();

        //添加职工信息
        bool InsertWorkerInfo(WorkerEntity obj);
        //删除员工信息
        bool DeleteWorkerInfo(string jobnumber);

        //修改员工信息
        bool UpdateWokerInfo(WorkerEntity obj, string jobnumber);

        //查询
        DataTable SelectWorkerInfo(string name);
    }
}
