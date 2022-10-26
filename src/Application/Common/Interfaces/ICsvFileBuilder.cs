using StoryBook.Application.TodoLists.Queries.ExportTodos;

namespace StoryBook.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
