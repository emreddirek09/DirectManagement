using DirectManagement.DOMAIN.Entities.BaseEntitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN.Entities.Concretes
{
    public class Comment : Base
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
