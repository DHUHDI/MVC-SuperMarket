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
    class WorkerManageControllerImpl : IWorkerManageController
    {
        IWorkerManageDataService worker = new WorkerManageDataImpl();

        public bool DeleteWorkerInfo(string jobnumber)
        {
            bool term = worker.DeleteInfo(jobnumber);
            return term;
        }

        public bool InsertWorkerInfo(WorkerEntity obj)
        {
            bool term = worker.InsertInfo(obj);
            return term;
        }

        public void JudgeNull(WorkerEntity obj)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectWorkerInfo(string name)
        {
            DataTable data = worker.SelectLittleInfo(name);

            return data;
        }

        //添加新数据后显示表
        public DataTable ShowNewTable()
        {
      
            DataTable data = worker.AddSelectInfo();

            return data;
        }

        public DataTable ShowTable()
        {

          
            DataTable data = worker.SelectAllInfo();

            return data;
            
        }

        public bool UpdateWokerInfo(WorkerEntity obj, string jobnumber)
        {
            bool term = worker.UpdateInfo(obj,jobnumber);
            return term;
        }
    }
}
