﻿using DirectManagement.APP.BaseResult.Concretes;

namespace DirectManagement.UI.Helpers.ClientHelper
{
    public interface IDirectClient
    {
        Task<DataResult<T>> Add<T>(T root, string uri);
        Task<DataResult<T>> Update<T>(T root, string uri);
        Task<DataResult<T>> Action<T, TData>(string uri, TData root);
        Task<DataResult<T>> Get<T>(string uri, T root);
        Task<DataResult<T>> GetNoRoot<T>(string uri);
        Task<DataResult<List<T>>> GetList<T>(string uri);
        Task<DataResult<T>> Delete<T>(string uri);
        Task<DataResult<TResult>> PostAsync<T, TResult>(T root, string uri);
    }
}
