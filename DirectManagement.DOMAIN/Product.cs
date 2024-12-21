using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN
{
    public class Product : Base
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public long ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public char Status { get; set; }
    }
}
