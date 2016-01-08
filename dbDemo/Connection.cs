using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDemo
{
    class Connection
    {
        private static SqlConnection conn;

        private static string ip;
       
        public static string ServerIP
        {
            set
            {
                ip = value;
            }
            get
            {
                return ip;
            }
        }

        public static SqlConnection getConnection()
        {
            if (!string.IsNullOrWhiteSpace(ip))
            {
                if (conn != null)
                {
                    return conn;
                }
                //配置连接属性
                SqlConnectionStringBuilder sqlbuilder = new SqlConnectionStringBuilder();
                sqlbuilder.DataSource = ip;
                sqlbuilder.InitialCatalog = "PosDB";   //数据库名
                sqlbuilder.IntegratedSecurity = true;

                conn = new SqlConnection();
                conn.ConnectionString = sqlbuilder.ConnectionString;

                return conn;
            }
            return null;
        }
    }
}
