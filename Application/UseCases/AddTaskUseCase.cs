using Todo.Domain.Entities;
using Todo.Domain.Interfaces;

namespace Todo.Application.UseCases;

public class AddTaskUseCase(ITaskRepository taskRepository)
{
    public void Execute(TaskEntity taskEntity)
    {
        taskRepository.Save(taskEntity);
    }
}
