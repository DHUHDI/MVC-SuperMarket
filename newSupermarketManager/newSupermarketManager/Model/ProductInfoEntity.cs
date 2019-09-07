using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSupermarketManager.Model
{
    /**
     * 商品信息实体
     * */
   public class ProductInfoEntity
    {
        private string productId;//产品id
        private string productname;//产品名称
        private string merchantname;//商家名称
        private int costprice;//成本价
        private int unitprice;//单价
        private int merchantinventory;//商品库存
        private string remarks;//备注

        public ProductInfoEntity()
        {
        }

        public ProductInfoEntity(string productId, string productname, string merchantname, int costprice, int unitprice, int merchantinventory, string remarks)
        {
            this.productId = productId;
            this.productname = productname;
            this.merchantname = merchantname;
            this.costprice = costprice;
            this.unitprice = unitprice;
            this.merchantinventory = merchantinventory;
            this.remarks = remarks;
        }

        public string ProductId { get => productId; set => productId = value; }
        public string Productname { get => productname; set => productname = value; }
        public string Merchantname { get => merchantname; set => merchantname = value; }
        public int Costprice { get => costprice; set => costprice = value; }
        public int Unitprice { get => unitprice; set => unitprice = value; }
        public int Merchantinventory { get => merchantinventory; set => merchantinventory = value; }
        public string Remarks { get => remarks; set => remarks = value; }
    }
}
