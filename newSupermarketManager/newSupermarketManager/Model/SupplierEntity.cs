using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSupermarketManager.Model
{
    /**
     * 供货商实体
     * */
    public class SupplierEntity
    {
        private string supplierId;//供货商ID
        private string merchantname;//商家名称
        private string contacts;//联系人
        private string phone;//手机号
        private string address;//地址
        private string settlement;//结算方式


       public  SupplierEntity()
        { }

        public SupplierEntity(string supplierId, string merchantname, string contacts, string phone, string address, string settlement)
        {
            this.supplierId = supplierId;
            this.merchantname = merchantname;
            this.contacts = contacts;
            this.phone = phone;
            this.address = address;
            this.settlement = settlement;
        }

        public string SupplierId { get => supplierId; set => supplierId = value; }
        public string Merchantname { get => merchantname; set => merchantname = value; }
        public string Contacts { get => contacts; set => contacts = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Settlement { get => settlement; set => settlement = value; }
    }
}
