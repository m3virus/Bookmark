
using Bookmark.Entities.Entities;
using Bookmark.Infrastructure.Repository;
using Bookmark.Usecase.Bases;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookmark.Test.Bookmarks
{
    public class BookmarksUnitTests
    {
        #region CreateBookmark
        [Fact]
        public async Task CreateBookmark_WithValidData_ReturnsCreatedBookmark()
        {  
            //arrange 
            var bookmarkRepo = new Mock<IBookmarkRepository>();
            var bookmarkModel = new BookmarkEntity
            {
                Title = "Title",
                Url = "URL",
            };
            //act
            bookmarkRepo
                .Setup(x => x.CreateAsync(It.IsAny<BookmarkEntity>()))
                .ReturnsAsync(new BaseResponse<BookmarkEntity>
                {
                    
                });
            var result = await bookmarkRepo.Object.CreateAsync(bookmarkModel);
            //todo: check the database too
            //assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);

        }
        [Fact]
        public void CreateBookmark_WithEmptyTitle_ThrowsValidationException()
        {

        }
        [Fact]
        public void CreateBookmark_WithNewTags_AutoCreatesTagsAndBookmark()
        {

        }

        [Fact]
        public void CreateBookmark_WithInvalidUrl_ThrowsValidationException()
        {

        }
        [Fact]
        public void CreateBookmark_WithNewTagNames_CreatesTagsThenLinksThem()
        {

        }
        [Fact]
        public void CreateBookmark_WithExistingTagNames_ReusesExistingTags()
        {

        }
        [Fact]
        public void CreateBookmark_OnSuccess_InvalidatesListCache()
        {

        }
        #endregion

        #region GetBookmark
        [Fact]
        public void GetBookmark_CacheHit_DoesNotCallRepository()
        {

        }

        [Fact]
        public void GetBookmark_CacheMiss_FallsBackToRepository()
        {

        }

        [Fact]
        public void GetBookmark_CacheMiss_PopulatesCacheAfterFetch()
        {

        }

        [Fact]
        public void GetBookmark_NotFound_ThrowsNotFoundException()
        {

        }
        #endregion

        #region BookmarkList
        [Fact]
        public void ListBookmarks_Paginated_ReturnsCorrectPage()
        {

        }

        [Fact]
        public void ListBookmarks_CacheHit_DoesNotCallRepository()
        {

        }

        [Fact]
        public void ListBookmarks_CacheMiss_FallsBackToRepository()
        {

        }

        [Fact]
        public void ListBookmarks_FilteredByTag_PassesTagToRepository()
        {

        }

        [Fact]
        public void ListBookmarks_WithInvalidPage_ThrowsValidationException()
        {

        }
        #endregion

        #region UpdateBookmark
        [Fact]
        public void UpdateBookmark_WithValidData_UpdatesSuccessfully()
        {

        }

        [Fact]
        public void UpdateBookmark_NotFound_ThrowsNotFoundException()
        {

        }

        [Fact]
        public void UpdateBookmark_InvalidatesItemCache()
        {

        }

        [Fact]
        public void UpdateBookmark_InvalidatesListCache()
        {

        }

        [Fact]
        public void UpdateBookmark_WithNewTags_CreatesNewTags()
        {

        }

        [Fact]
        public void UpdateBookmark_RemovesTags_DetachesCorrectly()
        {

        }
        #endregion

        #region DeleteBookmark
        [Fact]
        public void DeleteBookmark_ExistingId_DeletesSuccessfully()
        {

        }

        [Fact]
        public void DeleteBookmark_NotFound_ThrowsNotFoundException()
        {

        }

        [Fact]
        public void DeleteBookmark_InvalidatesItemCache()
        {

        }

        [Fact]
        public void DeleteBookmark_InvalidatesListCache()
        {

        }

        #endregion


    }
}
