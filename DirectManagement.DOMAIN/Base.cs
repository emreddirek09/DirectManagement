﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
        virtual public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }


    }
}
