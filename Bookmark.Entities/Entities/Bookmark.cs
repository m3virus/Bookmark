using Bookmark.Entities.Bases;

namespace Bookmark.Entities.Entities
{
    public sealed class Bookmark: BaseEntity
    {
        public required string Url { get; set; }
        public required string Title { get; set; }
        public string? Notes { get; set; } = null;
    }
}
