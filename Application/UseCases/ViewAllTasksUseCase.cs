using Todo.Domain.Entities;
using Todo.Domain.Interfaces;

namespace Todo.Application.UseCases;

public class ViewAllTasksUseCase(ITaskRepository taskRepository)
{
    public IEnumerable<TaskEntity> Execute()
    {
        return taskRepository.GetAll();
    }
}
