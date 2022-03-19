namespace Business.Models;

public class Todo
{
    public Todo(string title, bool isCompleted)
    {
        Title = title;
        IsCompleted = isCompleted;
    }

    public string Title { get; set; }
    public bool IsCompleted { get; set; }
}
