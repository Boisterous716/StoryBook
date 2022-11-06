using Microsoft.AspNetCore.Mvc;
using StoryBook.Application.Albums.Commands;

namespace StoryBook.WebUI.Controllers;

public class AlbumsController : ApiControllerBase
{
    [HttpPost]
    public async Task<ActionResult<int>> Create(CreateAlbumCommand command)
    {
        return await Mediator.Send(command);
    }
}
