using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN
{
    public class OparationHour
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public DateTime StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public char Status { get; set; }

    }
}
