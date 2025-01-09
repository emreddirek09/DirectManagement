using DirectManagement.DOMAIN.Entities.BaseEntitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN.Entities.Concretes
{
    public class Main : Base
    {
        public string CompanyName { get; set; }
        public string CompanyNo { get; set; }
        public string SiteTitle { get; set; }
        public string WebLink { get; set; }
    }
}
