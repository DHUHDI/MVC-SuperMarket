using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newSupermarketManager.Mysql
{
    class SelectMysql
    {
        public static MySqlConnection con = Connectionsql.Connection();
       
        //查询全表
        public static MySqlDataReader reader(string selectStr)
        {
            con.Close();
            con.Open();
            MySqlCommand command = new MySqlCommand(selectStr, con);
            
            MySqlDataReader reader = command.ExecuteReader();

            
            return reader;

        }

        //查询全表并绑定在datatable中
        public static DataTable datatable(string selectStr)
        {
            con.Close();
            con.Open();
            MySqlCommand command = new MySqlCommand(selectStr, con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(selectStr, Connectionsql.ConnectStr());
            DataTable dataTable= new DataTable();
            adapter.Fill(dataTable);
            
            con.Close();
            return dataTable;
        }

        //修改，删除，添加返回bool ,1则为true
        public static bool result(string selectStr)
        {
            con.Close();
            bool term = false;
            con.Open();
            MySqlCommand command = new MySqlCommand(selectStr, con);
            int result = command.ExecuteNonQuery();
            if (result == 1)
            {
                term = true;
            }
         
            return term;
        }

        //查询表中数据条数
        public static int datanumber(string selectStr)
        {
            con.Close();
            con.Open();

            MySqlCommand cmd = new MySqlCommand(selectStr, con);
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            con.Dispose();
            int data= ds.Tables[0].Rows.Count;
            con.Close();
            return data;
        }
        //查询表中新添加的数据
        public static DataTable selectnew(string selectStr)
        {
            con.Close();
            con.Open();
            MySqlCommand command = new MySqlCommand(selectStr, con);
            command.ExecuteNonQuery();
            DataSet dataSet = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectStr, Connectionsql.ConnectStr());
            adapter.SelectCommand = command;
            adapter.Fill(dataSet);
            DataTable data = dataSet.Tables[0];
            con.Close();
            return data;
        }

        public static List<string> selectlist(string selectStr,string column)
        {
            con.Close();
            con.Open();
            MySqlCommand command = new MySqlCommand(selectStr, con);


            MySqlDataReader reader = command.ExecuteReader();

            List<string> list = new List<string> { };
            while (reader.Read())
            {
                string str = reader.GetString(column);
                list.Add(str);
            }
            return list;
        }
    }
}
