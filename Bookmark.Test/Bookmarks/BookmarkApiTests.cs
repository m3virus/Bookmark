using System;
using System.Collections.Generic;
using System.Text;

namespace Bookmark.Test.Bookmarks
{
    public class BookmarkApiTests
    {
        [Fact]
        public void GET_Bookmarks_WithoutApiKey_Returns401()
        {

        }
        [Fact]
        public void POST_Bookmarks_WithoutApiKey_Returns401()
        {

        }
        [Fact]
        public void GET_Bookmarks_WithInvalidApiKey_Returns401()
        {

        }
        [Fact]
        public void POST_Bookmarks_WithValidData_Returns201WithLocationHeader()
        {

        }
        [Fact]
        public void POST_Bookmarks_WithInvalidUrl_Returns400WithValidationError()
        {

        }
        [Fact]
        public void POST_Bookmarks_WithEmptyTitle_Returns400WithValidationError()
        {

        }
        [Fact]
        public void POST_Bookmarks_WithNewTags_AutoCreatesTagsInDatabase()
        {

        }
        [Fact]
        public void GET_Bookmarks_ById_Returns200WithCorrectData()
        {

        }
        [Fact]
        public void GET_Bookmarks_ByNonExistingId_Returns404()
        {

        }
        [Fact]
        public void GET_Bookmarks_Returns200WithPaginatedList()
        {

        }
        [Fact]
        public void GET_Bookmarks_FilteredByTag_ReturnsOnlyMatchingResults()
        {

        }
        [Fact]
        public void GET_Bookmarks_SecondCallWithinTtl_IsServedFromCache()
        {

        }
        [Fact]
        public void GET_Bookmarks_WithInvalidPage_Returns400()
        {

        }
        [Fact]
        public void PUT_Bookmarks_WithValidData_Returns200()
        {

        }
        [Fact]
        public void PUT_Bookmarks_NonExistingId_Returns404()
        {

        }
        [Fact]
        public void PUT_Bookmarks_WithInvalidData_Returns400()
        {

        }
        [Fact]
        public void DELETE_Bookmarks_ExistingId_Returns204()
        {

        }
        [Fact]
        public void DELETE_Bookmarks_NonExistingId_Returns404()
        {

        }
    }
}
