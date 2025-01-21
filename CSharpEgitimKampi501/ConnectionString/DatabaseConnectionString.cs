using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.ConnectionString
{
    internal class DatabaseConnectionString
    {
    public static void SQLDatabaseConnectionString()
        {
            SqlConnection connection = new SqlConnection("SERVER=EV\\SQLEXPRESS;initial catalog=EgitimKampi501Db;integrated security=true");
        }



    }
}
