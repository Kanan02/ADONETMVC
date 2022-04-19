using AdoNetMVC.Models.Concrete;
using System.Threading.Tasks;

namespace AdoNetMVC.Services.Interfaces
{
    public interface IBookService
    {
        Task<Book> GetBook(int id);
    }
}
