﻿using DirectManagement.APP.BaseResult.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.APP.Repositories.Repository
{
    public interface IWriteRepository<T> : IRepository<T> where T : class
    {
        Task<bool> AddAsync(T values);
        Task<bool> AddRangeAsync(List<T> values);
        bool Delete(T values);
        bool Update(T values);
        Task<int> SaveAsync();
    }
}
