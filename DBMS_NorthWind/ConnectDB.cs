using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_NorthWind
{
    internal class ConnectDB
    {
        public static SqlConnection ConnectNorthwind()
        {
            string server = @".\sqlexpress"; 
            string db = "northwind"; 
            string userId = "Titus"; 
            string password = "Ultrama"; 

            
            string strCon = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};Password={3};Encrypt=False", 
                                          server, db, userId, password);
            
            SqlConnection conn = new SqlConnection(strCon); 
            conn.Open(); 
            return conn; 
        }
    }
}
