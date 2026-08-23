using System;
using System.Collections.Generic;
using System.Text;

namespace Bookmark.Test.Bookmarks
{
    public class BookmarksIntegrationTest
    {
        [Fact]
        public void Insert_ThenGetById_ReturnsSamePersistedValues()
        {

        }
        [Fact]
        public void Insert_WithNullNotes_PersistsSuccessfully()
        {

        }
        [Fact]
        public void Insert_SetsCreatedAtAndUpdatedAt_Automatically()
        {

        }
        [Fact]
        public void List_NoFilter_ReturnsAllBookmarksPaginated()
        {

        }
        [Fact]
        public void Update_ChangesTitle_PersistsCorrectly()
        {

        }
        [Fact]
        public void Update_ChangesNotes_PersistsCorrectly()
        {

        }
        [Fact]
        public void Update_SetsUpdatedAt_ToCurrentTime()
        {

        }
        [Fact]
        public void List_FilteredByTag_ReturnsOnlyMatchingBookmarks()
        {

        }
        [Fact]
        public void List_PageTwo_ReturnsCorrectOffset()
        {

        }
        [Fact]
        public void List_EmptyDatabase_ReturnsEmptyList()
        {

        }
        [Fact]
        public void Delete_ExistingBookmark_RemovesFromDatabase()
        {

        }
        [Fact]
        public void Delete_CascadesBookmarkTagRows()
        {

        }
        [Fact]
        public void Delete_NonExistingId_ReturnsFalseOrNoOp()
        {

        }
        [Fact]
        public void Attach_TagToBookmark_CreatesRelation()
        {

        }
        [Fact]
        public void Attach_DuplicateRelation_ThrowsOrIgnores()
        {

        }
        [Fact]
        public void Detach_TagFromBookmark_RemovesRelation()
        {

        }
        [Fact]
        public void Detach_NonExistingRelation_DoesNotThrow()
        {

        }
        
    }
}
