using DirectManagement.DOMAIN.DTOS.BaseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN.DTOS
{
    public class CategoryDto:BaseDto
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
