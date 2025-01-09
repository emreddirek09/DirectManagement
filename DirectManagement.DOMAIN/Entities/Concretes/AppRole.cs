using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN.Entities.Concretes
{
    public class AppRole : IdentityRole<int>
    {
        public DateTime? CreateDate { get; set; }
        virtual public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
