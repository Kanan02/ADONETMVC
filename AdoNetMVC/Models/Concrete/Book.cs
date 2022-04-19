namespace AdoNetMVC.Models.Concrete
{
    public class Book:Base
    {
        public string Name { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }
        public int Stock  { get; set; }
    }
}
