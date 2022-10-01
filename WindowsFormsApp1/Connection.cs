using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using DevExpress.ClipboardSource.SpreadsheetML;

namespace WindowsFormsApp1
{
    class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-6VS9H80\SQLEXPRESS;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
