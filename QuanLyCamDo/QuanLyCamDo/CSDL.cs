using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyCamDo
{
    class CSDL
    {
        public static SqlConnection ketnoi;
        public static void Connect()
        {
            string chuoiketnoi = @"Data Source=LAPTOP-V9IF4VVO\SQLEXPRESS;Initial Catalog=QLCD;Integrated Security=True";
            ketnoi = new SqlConnection(chuoiketnoi);
        }
    }
}
