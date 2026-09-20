using Bookmark.Entities.Entities;
using Bookmark.Usecase.Bases;

namespace Bookmark.Infrastructure.Repository
{
    public class BookmarkRepository : BaseRepository<BookmarkEntity>, IBookmarkRepository
    {
        public override Task<BaseResponse<BookmarkEntity>> CreateAsync(BookmarkEntity entity)
        {
            throw new NotImplementedException();
        }

        public override Task<BaseResponse<BookmarkEntity>> UpdateAsync(BookmarkEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
