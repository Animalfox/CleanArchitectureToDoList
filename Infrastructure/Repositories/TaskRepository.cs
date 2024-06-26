using Todo.Domain.Interfaces;
using Task = Todo.Domain.Entities.Task;

namespace Todo.Infrastructure.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly List<Task> _tasks = [];

    public Task GetById(int id)
    {
        return _tasks.FirstOrDefault(t => t.Id == id) ?? throw new InvalidOperationException();
    }

    public void Save(Task task)
    {
        // Simulated saving to a datastore
        _tasks.Add(task);
    }

    public IEnumerable<Task> GetAll()
    {
        return _tasks;
    }
}
