﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN
{
    public class Review : Base
    { 
        public string Name { get; set; }
        public string Title { get; set; }
        public string YourReview { get; set; }
        public int Quality { get; set; }
    }
}