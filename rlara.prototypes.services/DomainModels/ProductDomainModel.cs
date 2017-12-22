using System;
using System.Collections.Concurrent;

namespace rlara.prototypes.services.DomainModels
{
    public class ProductDomainModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public ConcurrentBag<ImageDomainModel> Images { get; set; }
    }
}