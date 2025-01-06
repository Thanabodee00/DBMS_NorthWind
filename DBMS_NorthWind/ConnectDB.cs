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
            string server = @".\sqlexpress"; // ชื่อเซิร์ฟเวอร์
            string db = "northwind"; // ชื่อฐานข้อมูล
            string strCon = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True;Encrypt=False", server, db);
            SqlConnection conn = new SqlConnection(strCon); // สร้าง Connection ด้วย Connection String
            //string strCon = 
            conn.Open(); // เปิดการเชื่อมต่อ
            return conn;
        }
    }
}
