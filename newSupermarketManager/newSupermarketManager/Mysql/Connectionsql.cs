using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSupermarketManager.Mysql
{
   public  class Connectionsql
    {
        public static string ConnectStr()
        {
            string connectStr = "Database=" +
                MysqlObject.database +
               ";Data Source=" +
               MysqlObject.datasource +
               ";User Id=" +
               MysqlObject.userId +
               ";Password="
               + MysqlObject.password;

            return connectStr;
        }
        //连接数据库
        public static MySqlConnection Connection()
        {
            string connectStr = ConnectStr();
            MySqlConnection con = new MySqlConnection(connectStr);
            return con;

        }

      

      


    }
}
