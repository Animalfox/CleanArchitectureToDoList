using Todo.Domain.Interfaces;

namespace Todo.Application.UseCases;

public class AddTaskUseCase(ITaskRepository taskRepository)
{
    public void Execute(Task task)
    {
        taskRepository.Save(task);
    }
}
