using AdoNetMVC.Repositories.Abstract;

namespace AdoNetMVC.Repositories.Concrete
{
    public class AppData : IAppData
    {
        private readonly BookRepository bookRepository;
        public BookRepository BookRepository => bookRepository??new BookRepository();

    }
}
