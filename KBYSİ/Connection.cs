using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBYSİ
{
    class Connection
    {
        public SqlConnection openConnection()
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-NF2BKIK9\\SQLEXPRESS;Initial Catalog=BloodBank;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}
