using MediatR;
using StoryBook.Application.Common.Interfaces;
using StoryBook.Domain.Entities;

namespace StoryBook.Application.Albums.Commands;
public record CreateAlbumCommand : IRequest<int>
{
    public string Title { get; set; }
    public string? Note { get; set; }
}

public class CreateAlbumCommandHandler : IRequestHandler<CreateAlbumCommand, int>
{
    private readonly IApplicationDbContext _context;
    public CreateAlbumCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateAlbumCommand request, CancellationToken cancellationToken)
    {
        var album = new Album
        {
            Title = request.Title,
            Note = request.Note
        };

        _context.Albums.Add(album);

        await _context.SaveChangesAsync(cancellationToken);

        return album.Id;
    }
}
