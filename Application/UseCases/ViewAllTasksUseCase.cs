using Todo.Domain.Interfaces;

namespace Todo.Application.UseCases;

public class ViewAllTasksUseCase(ITaskRepository taskRepository)
{
    public IEnumerable<Task> Execute()
    {
        return taskRepository.GetAll();
    }
}
