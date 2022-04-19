using AdoNetMVC.Repositories.Concrete;

namespace AdoNetMVC.Repositories.Abstract
{
    public interface IAppData
    {
        public BookRepository BookRepository { get; }
    }
}
