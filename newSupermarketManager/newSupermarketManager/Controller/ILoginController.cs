using newSupermarketManager.ControllerBase;
using newSupermarketManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSupermarketManager.Controller
{
    interface ILoginController:IController<WorkerEntity>
    {
        //跳转界面
        void JumpShow(WorkerEntity obj);

        //访问数据库
        bool VisitDatabase(WorkerEntity obj);

        //插入数据库
        bool InsertDatabase(WorkerEntity obj);

        //判断重复
        bool Register(WorkerEntity obj);
        
    }
}
