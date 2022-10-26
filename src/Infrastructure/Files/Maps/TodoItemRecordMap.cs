using System.Globalization;
using StoryBook.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace StoryBook.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
