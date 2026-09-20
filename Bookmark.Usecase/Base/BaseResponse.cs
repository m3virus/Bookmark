using System;
using System.Collections.Generic;
using System.Text;

namespace Bookmark.Usecase.Bases
{
    public class BaseResponse
    {
       public bool IsSuccess { get; set; }
    }

    public class BaseResponse<T> : BaseResponse
    {

    }
}
