using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN
{
    public class NewsLetter : Base
    { 
        public string Email { get; set; }
        public char Status { get; set; }
    }
}
