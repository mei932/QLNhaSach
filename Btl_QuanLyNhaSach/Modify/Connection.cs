﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Btl_QuanLyNhaSach
{
    class Connection
    {
        // Đường liên kết tới sql
       // private static string stringConnection = @"Data Source=DESKTOP-ESFTV9I\SQLEXPRESS;Initial Catalog=SQLHT1;Integrated Security=True";

        private static string stringConnection = @"Data Source=125.212.225.233,14333;Initial Catalog=exam;Persist Security Info=True;User ID=sa;Password=Thearrow199*";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
//Some files need fixing
// connection
// thongketheonam.cs
//trangchu.cs