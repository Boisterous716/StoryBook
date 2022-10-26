using StoryBook.Application.Common.Interfaces;

namespace StoryBook.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
