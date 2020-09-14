using blazor_app.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace blazor_app.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
