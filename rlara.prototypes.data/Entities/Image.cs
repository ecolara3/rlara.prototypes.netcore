using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rlara.prototypes.data.Entities
{
    public class Image
    {
        public int Id { get; set; }
        [Required]
        public string Uri { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string CreationDate { get; set; }
        
        public int? ProductId { get; set; }
        public int? CategoryId { get; set; }
        
    }
}