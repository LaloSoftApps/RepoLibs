using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LibDB
{
    public class DBSqlConn
    {
        public static string DBServer { get; set; }
        public static string DBName { get; set; }
        public static string DBUser { get; set; }
        public static string DBUserPwd { get; set; }

        // public static DataSet Exec(string DBServer, string DBName, string DBUser, string DBUserPwd, string Query)
        public static DataSet Exec(string Query)
        {
            SqlConnection Conn;
            Conn = new SqlConnection("Server=" + DBServer + ";Database=" + DBName + ";User Id=" + DBUser + ";Password=" + DBUserPwd + ";");
            Conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(Query, Conn);
            da.Fill(ds);

            Conn.Close();
            return ds;
        }
        
    }
}
