using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rlara.prototypes.data.Entities
{
    public class Category
    {
        public int Id {get;set;}
        [Required]
        public string Name { get; set; }
        public string Descritpion { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string CreationDate { get; set; }

    }
}