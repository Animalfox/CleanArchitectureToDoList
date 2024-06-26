using Todo.Application.UseCases;
using Todo.Infrastructure.Repositories;
using Task = Todo.Domain.Entities.Task;

var taskRepository = new TaskRepository();
var addTaskUseCase = new AddTaskUseCase(taskRepository);
var viewAllTasksUseCase = new ViewAllTasksUseCase(taskRepository);

// Пример использования
Console.WriteLine("Добавление новой задачи:");
var newTask = new Task
{
    Id = 1,
    Title = "Почистить код",
    Description = "Оптимизировать исходный код приложения",
    IsCompleted = false
};
addTaskUseCase.Execute(newTask);

Console.WriteLine("Все задачи в списке:");
var tasks = viewAllTasksUseCase.Execute();
foreach (var task in tasks)
{
    Console.WriteLine($"Задача: {task.Title}, Описание: {task.Description}, Завершено: {task.IsCompleted}");
}
