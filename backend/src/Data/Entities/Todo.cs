namespace Data.Entities;

public class Todo
{
    public Todo(string title, bool isCompleted)
    {
        Title = title;
        IsCompleted = isCompleted;
    }

    public Guid Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }
}
