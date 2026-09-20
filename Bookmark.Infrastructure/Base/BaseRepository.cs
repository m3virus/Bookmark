namespace Bookmark.Usecase.Bases
{
    public abstract class BaseRepository<T>
    {
        public abstract Task<BaseResponse<T>> CreateAsync(T entity);
        public virtual Task<BaseResponse<T>> DeleteAsync(Guid Id)
        {
            throw new NotImplementedException();
        }
        public abstract Task<BaseResponse<T>> UpdateAsync(T entity);
        //todo: it should complete with search params
        public virtual Task<BaseResponse<T>> GetAsync()
        {
            throw new NotImplementedException();
        }
        //TODO: it should complete with options
        public virtual Task<BaseResponse<T>> GetByOptionAsync()
        {
            throw new NotImplementedException();
        }


    }
}
