using Todo.Domain.Entities;

namespace Todo.Domain.Interfaces;

public interface ITaskRepository
{
    TaskEntity GetById(int id);
    void Save(TaskEntity taskEntity);
    IEnumerable<TaskEntity> GetAll();
}
