using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN
{
    public class Category : Base
    { 
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageSM { get; set; }
        public string ImageLG { get; set; }
        public string MetaTitle { get; set; }
        public int Level { get; set; }
        public long Price { get; set; }
    }
}
