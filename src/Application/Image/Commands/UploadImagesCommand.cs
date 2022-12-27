using MediatR;
using StoryBook.Application.Common.Interfaces;
using StoryBook.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace StoryBook.Application.Image.Commands;
public record UploadImagesCommand : IRequest
{
    private List<ImageModel> _imageModels;
    public List<ImageModel> Files { get => _imageModels; set => _imageModels = value; }
}

public class ImageModel {
    public ImageModel(IFormFile file)
    {
        File = file;
    }

    IFormFile File { get; set; }
    string? Description { get; set; }
}

public class UploadImagesCommandHandler : IRequestHandler<UploadImagesCommand>
{
    private readonly IApplicationDbContext _context;
    public UploadImagesCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(UploadImagesCommand request, CancellationToken cancellationToken)
    {
        foreach(var img in request.Files)
        {
            
        }
        var album = new Album
        {
            Title = request.Title,
            Note = request.Note
        };

        _context.Albums.Add(album);

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
