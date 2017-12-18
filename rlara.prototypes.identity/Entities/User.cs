using System;
using Microsoft.AspNetCore.Identity;

namespace rlara.prototypes.identity.Entities
{
    public class User:IdentityUser
    {
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }

    }
}