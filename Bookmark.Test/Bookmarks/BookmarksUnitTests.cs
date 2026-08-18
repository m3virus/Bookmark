
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookmark.Test.Bookmarks
{
    public class BookmarksUnitTests
    {
        [Fact]
        public void CreateBookmark_WithValidData_ReturnsCreatedBookmark()
        {

        }
        [Fact]
        public void CreateBookmark_WithEmptyTitle_ThrowsValidationException()
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
        [Fact]
        public void ReadBookmark_OnSuccess_ValidId()
        {

        }

        [Fact]
        public void ReadBookmark_WithInvalidId_ReturnNull()
        {

        }
    }
}
