﻿namespace DirectManagement.APP.BaseResult.Concretes
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data) : base(data, false)
        {
        }

        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
        }

        public ErrorDataResult(string message) : base(default, false, message)
        {
        }
    }
}
