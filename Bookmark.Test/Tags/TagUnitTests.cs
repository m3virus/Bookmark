using System;
using System.Collections.Generic;
using System.Text;

namespace Bookmark.Test.Tags
{
    public class TagUnitTests
    {
        [Fact]
        public void ListTags_CacheHit_DoesNotCallRepository() 
        { 
        
        }
        [Fact]
        public void ListTags_CacheMiss_FallsBackToRepository() 
        { 
        
        }
        [Fact]
        public void ListTags_CacheMiss_PopulatesCache() 
        { 
        
        }
        [Fact]
        public void ListTags_ReturnsTagsWithBookmarkCount() 
        { 
        
        }
        [Fact]
        public void CreateTag_WithDuplicateName_ThrowsConflictException() 
        { 
        
        }
        [Fact]
        public void DeleteTag_Orphaned_DeletesSuccessfully() 
        { 
        
        }
        [Fact]
        public void DeleteTag_InvalidatesTagsCache() 
        { 
        
        }
    }
}
