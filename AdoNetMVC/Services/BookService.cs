using AdoNetMVC.Models.Concrete;
using AdoNetMVC.Repositories.Abstract;
using AdoNetMVC.Services.Interfaces;
using System.Threading.Tasks;

namespace AdoNetMVC.Services
{
    public class BookService : IBookService
    {
        private readonly IAppData _data;
        public BookService(IAppData data)
        {
            _data = data;
        }
        public async Task<Book> GetBook(int id)
        {
            return await _data.BookRepository.Get(id);
        }
    }
}
