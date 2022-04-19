using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace AdoNetMVC.Repositories
{
    public static class BooksContext
    {
        private static string  ConnectionString;

        public static SqlConnection GetConnection()
        {
           ConnectionString=  new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("SqlConnection");
            return new SqlConnection(ConnectionString);
        }
    }
}
