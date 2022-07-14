using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Account
{
    public class AuthenticationResponse
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string JWTToken { get; set; }
        public string Role { get; set; }
        public bool IsVerified { get; set; }
        public string RefreshToken { get; set; }
        
    }
}

