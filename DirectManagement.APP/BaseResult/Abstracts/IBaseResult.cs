﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.APP.BaseResult.Abstracts
{
    public interface IBaseResult
    {
        bool Success { get; set; }
        string Message { get; set; }
    }
}
