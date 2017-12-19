using System.Drawing;
using System.Dynamic;

namespace rlara.prototypes.services.DomainModels
{
    public class Image
    {

        private readonly Category _category;
        private readonly Product _product;
        
        public Image(Product product)
        {
            _product = product;
        }
        
        public Image(Category category)
        {
            _category = category;
        }

        public int Id { get; set; }
        public string Uri { get; set; }
        public string CreationDate { get; set; }
        public Product Product => _product;
        public Category Category => _category;
    }
}