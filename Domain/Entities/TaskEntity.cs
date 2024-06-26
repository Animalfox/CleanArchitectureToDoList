namespace Todo.Domain.Entities;

public class TaskEntity
{
    public int Id { get; init; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
}
