namespace Bookmark.Usecase.Bases
{
    internal abstract class BaseRepository<T>
    {
        public abstract Task<BaseResponse<T>> CreateAsync(T entity);
        public virtual Task<BaseResponse<T>> DeleteAsync(Guid Id);
        public abstract Task<BaseResponse<T>> UpdateAsync(T entity);
        //todo: it should complete with search params
        public abstract Task<BaseResponse<T>> GetAsync();
        //TODO: it should complete with options
        public abstract Task<BaseResponse<T>> GetByOptionAsync();


    }
}
