using Bookmark.Usecase.Bases;

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
