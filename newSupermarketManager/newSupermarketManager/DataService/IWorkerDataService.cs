using newSupermarketManager.DataServiceBase;
using newSupermarketManager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSupermarketManager.DataService
{
    interface IWorkerDataService:IDataService<WorkerEntity>
    {
        //判断是否已有用户
        bool SelectUniqueInfo(WorkerEntity obj);
    }
}
