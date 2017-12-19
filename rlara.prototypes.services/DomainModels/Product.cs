using System;
using System.Collections.Concurrent;

namespace rlara.prototypes.services.DomainModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public Category Category { get; set; }
        public ConcurrentBag<Image> Images { get; set; }
    }
}