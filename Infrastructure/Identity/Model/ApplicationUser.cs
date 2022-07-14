using Application.DTOs.Account;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string HashedPassword { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; }
        public bool OwnsToken(string token)
        {
            return this.RefreshTokens?.Find(x => x.Token == token) != null;
        }
    }
}
