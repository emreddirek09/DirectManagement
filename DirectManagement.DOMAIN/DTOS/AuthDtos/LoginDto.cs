using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN.DTOS.AuthDtos
{
    public class LoginDto
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
