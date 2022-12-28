using MediatR;
using StoryBook.Application.Common.Interfaces;
using StoryBook.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace StoryBook.Application.Image.Commands;
public record UploadImagesCommand : IRequest
{
    private List<IFormFile> _imageModels;
    public List<IFormFile> Files { get => _imageModels; set => _imageModels = value; }
}

public class UploadImagesCommandHandler : IRequestHandler<UploadImagesCommand>
{
    private readonly IApplicationDbContext _context;
    private readonly IOptions<FileConfiguration> _config;
    public UploadImagesCommandHandler(IApplicationDbContext context, IOptions<FileConfiguration> config)
    {
        _context = context;
        _config = config;
    }

    public async Task<Unit> Handle(UploadImagesCommand request, CancellationToken cancellationToken)
    {
        foreach(var img in request.Files)
        {
            if(img.Length > 0)
            {
                var filePath = Path.Combine(_config.Value.FilePath, img.FileName);

                using (var stream = System.IO.File.Create(filePath))
                {
                    await img.CopyToAsync(stream);
                }
            }
        }

        return Unit.Value;
    }
}
