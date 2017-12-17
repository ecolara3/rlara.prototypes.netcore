using Microsoft.AspNetCore.Identity;

namespace rlara.prototypes.data.Entities
{
    public class Role:IdentityRole
    {
        public string Description { get; set; }
    }
}