using System.Collections.Concurrent;

namespace rlara.prototypes.services.DomainModels
{
    public class Category
    {
        public int Id {get;set;}
        public string Name { get; set; }
        public string Descritpion { get; set; }
        public string CreationDate { get; set; }
        public ConcurrentBag<Product> Products { get; set; }
        public Image Image { get; set; }
    }
}