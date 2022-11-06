namespace StoryBook.Domain.Entities;

public class AlbumPhoto : BaseAuditableEntity
{
    public int AlbumId { get; set; }
    public Album Album { get; set; } = new Album();

    public int PhotoId { get; set; }
    public Photo Photo { get; set; } = new Photo();
}
