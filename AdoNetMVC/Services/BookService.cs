using AdoNetMVC.Models.Concrete;
using AdoNetMVC.Repositories.Abstract;
using AdoNetMVC.Services.Interfaces;
using System.Collections.Generic;
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
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _data.BookRepository.Get();
        }
        public async Task<int> AddBook(Book book)
        {
            return await _data.BookRepository.Add(book);
        }
        public async Task<int> DeleteBook(int id)
        {

            return await _data.BookRepository.Delete(id);
        }
    }
}
