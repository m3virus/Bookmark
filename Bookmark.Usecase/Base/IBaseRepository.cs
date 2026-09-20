using Bookmark.Usecase.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookmark.Usecase.Base
{
    public interface IBaseRepository<T>
    {
        Task<BaseResponse<T>> CreateAsync(T entity);
        Task<BaseResponse<T>> DeleteAsync(Guid Id);
        Task<BaseResponse<T>> UpdateAsync(T entity);
        Task<BaseResponse<IEnumerable<T>>> GetAsync();
        Task<BaseResponse<IEnumerable<T>>> GetByOptionAsync();



    }
}
