namespace Bookmark.Usecase.Bases
{
    public class BaseResponse
    {
        protected internal BaseResponse(bool isSuccess, string? message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
        public bool IsSuccess { get; private set; }
        public string? Message { get; private set; }

        public static BaseResponse Success() => new(true, null);
        public static BaseResponse Failure(string message) => new(false, message);
        public static BaseResponse Success<TRequest>(TRequest data) => new BaseResponse<TRequest>(data, true, null);
        public static BaseResponse Failure<TRequest>(string message) => new BaseResponse<TRequest>(default, false, null);

    }
    
    public class BaseResponse<T> : BaseResponse
    {
        public T Data { get; set; }

        protected internal BaseResponse(T data, bool isSuccess, string? message): base(isSuccess, message)
        {
            Data = data;
        }
        


    }
}
