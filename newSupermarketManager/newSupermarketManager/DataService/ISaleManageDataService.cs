using newSupermarketManager.DataServiceBase;
using newSupermarketManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSupermarketManager.DataService
{
    interface ISaleManageDataService : IDataService<SaleEntity>
    {
        List<string> SelectColumn(string column, string tableName);
    }
}
