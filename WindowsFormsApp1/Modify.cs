using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Modify
    {
        public Modify()
        {

        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<Taikhoan> Taikhoans(string query)
        {
            List<Taikhoan> taikhoans = new List<Taikhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while(dataReader.Read())
                {
                    taikhoans.Add(new Taikhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }   
                sqlConnection.Close();
            }    
            return taikhoans;
        }
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query,sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }    
        }
    }
}
