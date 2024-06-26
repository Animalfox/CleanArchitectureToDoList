using Todo.Domain.Entities;
using Todo.Domain.Interfaces;

namespace Todo.Infrastructure.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly List<TaskEntity> _tasks = [];

    public TaskEntity GetById(int id)
    {
        return _tasks.FirstOrDefault(t => t.Id == id) ?? throw new InvalidOperationException();
    }

    public void Save(TaskEntity taskEntity)
    {
        // Simulated saving to a datastore
        _tasks.Add(taskEntity);
    }

    public IEnumerable<TaskEntity> GetAll()
    {
        return _tasks;
    }
}
