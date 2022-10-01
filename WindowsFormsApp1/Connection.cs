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
        private static string stringConnection = @"Data Source=DESKTOP-EH4VAV8\SQLEXPRESS01;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
