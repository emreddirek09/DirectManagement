using DirectManagement.DOMAIN.Entities.BaseEntitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN.DTOS
{
    public class Main
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNo { get; set; }
        public string SiteTitle { get; set; }
        public string WebLink { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }

}
