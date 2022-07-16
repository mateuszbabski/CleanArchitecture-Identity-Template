using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Account
{
    public class AuthenticationResponse
    {
        public bool IsSuccess { get; set; }
        public string[] Errors { get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string JWTToken { get; set; }
        public List<string> Roles { get; set; }
        public string RefreshToken { get; set; }
        
    }
}

