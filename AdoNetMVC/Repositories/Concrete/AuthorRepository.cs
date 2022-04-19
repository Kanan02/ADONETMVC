using AdoNetMVC.Models.Concrete;
using AdoNetMVC.Repositories.Abstract;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AdoNetMVC.Repositories.Concrete
{
    public class AuthorRepository : IRepository<Author>
    {
        private readonly SqlConnection _connection;
        public AuthorRepository()
        {
            _connection = BooksContext.GetConnection();
        }
        public Task<int> Add(Author entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Edit(Author entity)
        {
            throw new System.NotImplementedException();
        }
        public async Task<IEnumerable<Author>> GetByBookId(int id)
        {
            using (IDbConnection db = _connection)
            {
                string query = @"Select Authors.* from BooksAuthors inner join Authors on Authors.Id=BooksAuthors.AuthorId  where BookId=@ID ";
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@ID", id);
                return await db.QueryAsync<Author>(query, dynamicParameters);
            }
        }

        public async Task<Author> Get(int id)
        {
            //using (IDbConnection db = _connection)
            //{
            //    string query = @"Select * from Authors where Id=@ID";
            //    DynamicParameters dynamicParameters = new DynamicParameters();
            //    dynamicParameters.Add("@ID", id);
            //    return await db.QueryFirstAsync<Author>(query, dynamicParameters);
            //}
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Author>> Get()
        {
            throw new System.NotImplementedException();
        }
    }
}
