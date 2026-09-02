using Bookmark.Entities.Bases;

namespace Bookmark.Entities.Entities
{
    public sealed class Tag: BaseEntity
    {
        public required string Name { get; set; }
    }
}
