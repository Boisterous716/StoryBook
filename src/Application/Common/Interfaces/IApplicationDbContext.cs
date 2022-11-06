using StoryBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace StoryBook.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    DbSet<Album> Albums { get; }
    DbSet<Photo> Photos { get; }
    DbSet<AlbumPhoto> AlbumPhotos { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
