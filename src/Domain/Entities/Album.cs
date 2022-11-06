namespace StoryBook.Domain.Entities;

public class Album : BaseAuditableEntity
{

    public string Title { get; set; }

    public string? Note { get; set; }
    public ICollection<AlbumPhoto> AlbumPhotos { get; set; } = new List<AlbumPhoto>();
}
