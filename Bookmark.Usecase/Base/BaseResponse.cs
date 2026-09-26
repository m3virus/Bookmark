namespace Bookmark.Usecase.Bases
{
    public class BaseResponse
    {
        protected internal BaseResponse(bool isSuccess, string? message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
        private bool IsSuccess { get; set; }
        private string? Message { get; set; }

        public static BaseResponse success() => new (true, null);
        public static BaseResponse failure(string message) => new (false, message);
        public static BaseResponse<T>(T data)

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
