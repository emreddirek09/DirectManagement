using DirectManagement.DOMAIN.DTOS.BaseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN.DTOS
{
    public class BannerDto:BaseDto
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public string Button { get; set; }
        public string Url { get; set; }
        public string WebImage { get; set; }
        public string MobileImage { get; set; }
    }
}
