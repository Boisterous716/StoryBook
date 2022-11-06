namespace StoryBook.Domain.Entities;

public class Photo : BaseAuditableEntity
{

    public string Name { get; set; }

    public string? Description { get; set; }
    public ICollection<AlbumPhoto> AlbumPhotos { get; set; } = new List<AlbumPhoto>();

}
