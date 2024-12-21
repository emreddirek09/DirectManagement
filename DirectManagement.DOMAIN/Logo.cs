using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN
{
    public class Logo
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string LogoUrl { get; set; }
        public int LogoHeight { get; set; }
        public int LogoWidth { get; set; }
    }
}
