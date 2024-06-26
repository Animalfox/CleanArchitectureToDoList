using Todo.Domain.Interfaces;
using Task = Todo.Domain.Entities.Task;

namespace Todo.Application.UseCases;

public class ViewAllTasksUseCase(ITaskRepository taskRepository)
{
    public IEnumerable<Task> Execute()
    {
        return taskRepository.GetAll();
    }
}
