using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSupermarketManager.Model
{
    /**
     * 进货单实体
     * */
    public class PurchaseEntity
    {
        private string purchaseId;//进货id
        private string productName;//产品名称
        private int purchaseNumber;//进货数量
        private int costprice;//成本价
        private int total;//总额
        private string purchaseDate;//进货日期
        private string experience;//经手人
        private string purchaseStatus;//进货状态

        public PurchaseEntity()
        {
        }

        public PurchaseEntity(string purchaseId, string productname, int purchasenumber, int costprice, int total, string purchasedate, string experience, string purchasestate)
        {
            this.purchaseId = purchaseId;
            this.productName = productname;
            this.purchaseNumber = purchasenumber;
            this.costprice = costprice;
            this.total = total;
            this.purchaseDate = purchasedate;
            this.experience = experience;
            this.purchaseStatus = purchasestate;
        }

        public string PurchaseId { get => purchaseId; set => purchaseId = value; }
        public string Productname { get => productName; set => productName = value; }
        public int Purchasenumber { get => purchaseNumber; set => purchaseNumber = value; }
        public int Costprice { get => costprice; set => costprice = value; }
        public int Total { get => total; set => total = value; }
        public string Purchasedate { get => purchaseDate; set => purchaseDate = value; }
        public string Experience { get => experience; set => experience = value; }
        public string Purchasestate { get => purchaseStatus; set => purchaseStatus = value; }
    }
}
