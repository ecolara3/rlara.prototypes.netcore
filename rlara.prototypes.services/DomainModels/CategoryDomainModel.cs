using System.Collections.Concurrent;

namespace rlara.prototypes.services.DomainModels
{
    public class CategoryDomainModel
    {
        public int Id {get;set;}
        public string Name { get; set; }
        public string Descritpion { get; set; }
        public string CreationDate { get; set; }
        public ConcurrentBag<ProductDomainModel> Products { get; set; }
        public ImageDomainModel Image { get; set; }
    }
}