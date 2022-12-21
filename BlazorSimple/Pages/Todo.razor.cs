using BlazorSimple.Shared;

namespace BlazorSimple.Pages
{
    public partial class Todo
    {
        private List<TodoItem> todos = new List<TodoItem>();
        private string newTodo = "";

        private async void AddTodo()
        {
            todos.Add(new TodoItem { Title = newTodo });
            await localStorage.SetItemAsync("todo", newTodo);
            newTodo = String.Empty;
        }
    }
}
