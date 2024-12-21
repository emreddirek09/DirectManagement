using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN
{
    public class Contact : Base
    { 
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string MapLink { get; set; }
        public string Phone { get; set; }
    }
}
