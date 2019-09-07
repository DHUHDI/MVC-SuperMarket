using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSupermarketManager.Model
{
    /**
     * 销售记录实体
     * */
    public class SaleEntity
    {
        private string salesrecordsId;//销售记录id
        private string productname;//产品名称
        private string saledate;//销售日期
        private int salenumber;//销售数量
        private string paymethod;//支付方式
        private string workername;//职工名称
        private string jobnumber;//工号

        public SaleEntity(string salesrecordsId, string productname, string saledate, int salenumber, string paymethod, string workername, string jobnumber)
        {
            this.salesrecordsId = salesrecordsId;
            this.productname = productname;
            this.saledate = saledate;
            this.salenumber = salenumber;
            this.paymethod = paymethod;
            this.workername = workername;
            this.jobnumber = jobnumber;
        }

        public string SalesrecordsId { get => salesrecordsId; set => salesrecordsId = value; }
        public string Productname { get => productname; set => productname = value; }
        public string Saledate { get => saledate; set => saledate = value; }
        public int Salenumber { get => salenumber; set => salenumber = value; }
        public string Paymethod { get => paymethod; set => paymethod = value; }
        public string Workername { get => workername; set => workername = value; }
        public string Jobnumber { get => jobnumber; set => jobnumber = value; }
    }
}
