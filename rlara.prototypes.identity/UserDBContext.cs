using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using rlara.prototypes.identity.Entities;

namespace rlara.prototypes.identity
{
    public class UserDBContext:IdentityDbContext<User, Role, string>
    {
        public UserDBContext(DbContextOptions<UserDBContext> options)
            : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }

    }
}