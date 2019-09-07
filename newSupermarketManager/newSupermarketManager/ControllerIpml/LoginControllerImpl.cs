using newSupermarketManager.Controller;
using newSupermarketManager.DataService;
using newSupermarketManager.DataServiceBase;
using newSupermarketManager.DataServiceImpl;
using newSupermarketManager.Model;
using newSupermarketManager.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newSupermarketManager.ControllerIpml
{
    class LoginControllerImpl : ILoginController
    {
        public bool InsertDatabase(WorkerEntity obj)
        {
            IWorkerDataService connect = new WorkerDataServiceImpl();
            bool term = connect.InsertInfo(obj);
            return term;
        }

        public void JudgeNull(WorkerEntity obj)
        {
            if (obj.Jobnumber == "")
            {
                MessageBox.Show("用户名不能为空！");
            }
            else if (obj.Password == "")
            {
                MessageBox.Show("密码不能为空！");
            }
            else if (obj.Workunit == "")
            {
                MessageBox.Show("工作单位不能为空！");
            }
        }

        public void JumpShow(WorkerEntity obj)
        {
            if (obj.Workunit == "人事管理")
            {
                WorkerManage worker = new WorkerManage();
                worker.Show();


            }
            else if (obj.Workunit == "销售管理")
            {

                SaleManage saleManage = new SaleManage();
                saleManage.Show();

            }
            else if (obj.Workunit == "进货管理")
            {
                PurchaseManage purchase = new PurchaseManage();
                purchase.Show();
            }
            else if (obj.Workunit == "库存管理")
            {

                StockManage stockManage = new StockManage();
                stockManage.Show();

            }
            else if (obj.Workunit == "销售员")
            {
                SalerManage salerManage = new SalerManage(obj);
                salerManage.Show();
            }
     

        }

        //判断是否重复
        public bool Register(WorkerEntity obj)
        {
            IWorkerDataService connect = new WorkerDataServiceImpl();
            bool term = connect.SelectUniqueInfo(obj);
            return term;
        }

        //登录
        public bool VisitDatabase(WorkerEntity obj)
        {
            IWorkerDataService connect = new WorkerDataServiceImpl();
            bool term = connect.SelectInfo(obj);
            return term;
        }


    }
}
