using AdoNetMVC.Models.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdoNetMVC.Services.Interfaces
{
    public interface IBookService
    {
        Task<Book> GetBook(int id);
        Task<IEnumerable<Book>> GetBooks();
        Task<int> AddBook(Book book);
        Task<int> DeleteBook(int id);
    }
}
