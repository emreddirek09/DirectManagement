using DirectManagement.DOMAIN.Entities.BaseEntitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN.Entities.Concretes
{
    public class Gallery : Base
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Image { get; set; }
        public string BigImage { get; set; }
        public string ImageLink { get; set; }
        public char Status { get; set; }

    }
}
