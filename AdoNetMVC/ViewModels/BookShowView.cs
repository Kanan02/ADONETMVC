using AdoNetMVC.Models.Concrete;
using System.Collections.Generic;

namespace AdoNetMVC.ViewModels
{
    public class BookShowView
    {
        public Book Book { get; set; }
        public IEnumerable<Author> Authors { get; set; }
    }
}
