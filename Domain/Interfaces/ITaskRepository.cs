namespace Todo.Domain.Interfaces;

public interface ITaskRepository
{
    Task GetById(int id);
    void Save(Task task);
    IEnumerable<Task> GetAll();
}
