using Todo.Domain.Interfaces;
using Task = Todo.Domain.Entities.Task;

namespace Todo.Application.UseCases;

public class AddTaskUseCase(ITaskRepository taskRepository)
{
    public void Execute(Task task)
    {
        taskRepository.Save(task);
    }
}
