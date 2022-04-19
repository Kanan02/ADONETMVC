using System;

namespace AdoNetMVC.Models.Concrete
{
    public class Author:Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

    }
}
