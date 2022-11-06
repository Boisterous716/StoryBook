using StoryBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StoryBook.Infrastructure.Persistence.Configurations;

public class AlbumPhotoConfiguration : IEntityTypeConfiguration<AlbumPhoto>
{
    public void Configure(EntityTypeBuilder<AlbumPhoto> builder)
    {
        builder
            .HasOne(a => a.Album)
            .WithMany(ap => ap.AlbumPhotos)
            .HasForeignKey(a => a.AlbumId);

        builder
            .HasOne(p => p.Photo)
            .WithMany(ap => ap.AlbumPhotos)
            .HasForeignKey(p => p.PhotoId);
    }
}
