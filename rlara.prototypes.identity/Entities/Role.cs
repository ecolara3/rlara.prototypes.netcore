using Microsoft.AspNetCore.Identity;

namespace rlara.prototypes.identity.Entities
{
    public class Role:IdentityRole
    {
        public string Description { get; set; }
    }
}