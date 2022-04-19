using AdoNetMVC.Models.Concrete;
using AdoNetMVC.Models.Enums;
using AdoNetMVC.Repositories.Abstract;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AdoNetMVC.Repositories.Concrete
{
    public class BookRepository : IRepository<Book>
    {
        private readonly SqlConnection _connection;
        public BookRepository()
        {
            _connection = BooksContext.GetConnection();
        }
        public Task<int> Add(Book entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Edit(Book entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Book> Get(int id)
        {

            using (IDbConnection db=_connection)
            {
                string query = @"Select * from Books where Id=@ID";
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@ID", id);
                return await db.QueryFirstAsync<Book>(query, dynamicParameters); 
            }
            
            //using (_connection)
            //{
            //    string query = @"Select * from Books where Id=@ID";
            //    SqlCommand command = new SqlCommand(query,_connection);
            //    command.Parameters.Add(new SqlParameter("@ID", id));
            //    _connection.Open();
            //    DataTable data = new DataTable();
            //    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            //    {
            //        adapter.Fill(data);
            //    }
            //    if (data!=null && data.Rows.Count>0)
            //    {
            //        DataRow dataRow = data.Rows[0];
            //        Book book = new Book()
            //        {
            //            Id = Convert.ToInt32(dataRow["id"]),
            //            Name = Convert.ToString(dataRow["Name"]),
            //            Pages = Convert.ToInt32(dataRow["Pages"]),
            //            Status =(Status)Convert.ToInt32(dataRow["Status"]),
            //            Price = Convert.ToDecimal(dataRow["Price"]),
            //            Stock = Convert.ToInt32(dataRow["Stock"])

            //        };
            //        return book;
            //    }
            //    return null;
            //}
        }

        public Task<IEnumerable<Book>> Get()
        {
            throw new System.NotImplementedException();
        }
    }
}
