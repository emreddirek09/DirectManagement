﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN.DTOS.AuthDtos
{
    public class RegisterDto
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Phone { get; set; }
        public string? ImagePath { get; set; }
        public string? Email { get; set; }
        public string? EmailConfirm { get; set; }
        public string? Password { get; set; }
        public string? PasswordConfirm { get; set; }
    }
}
