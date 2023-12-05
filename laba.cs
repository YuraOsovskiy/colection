using System;
using System.Collections.Generic;

// Завдання 1: Керування списком завдань
class Task
{
    public int TaskId { get; set; }
    public string Description { get; set; }
}

class TaskManager
{
    private List<Task> tasks = new List<Task>();

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void RemoveTask(int taskId)
    {
        Task taskToRemove = tasks.Find(t => t.TaskId == taskId);
        if (taskToRemove != null)
        {
            tasks.Remove(taskToRemove);
        }
    }

    public void DisplayTasks()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine($"Task ID: {task.TaskId}, Description: {task.Description}");
        }
    }
}

// Завдання 2: Управління списком користувачів
class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class UserManager
{
    private List<User> users = new List<User>();

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void RemoveUser(int userId)
    {
        User userToRemove = users.Find(u => u.Id == userId);
        if (userToRemove != null)
        {
            users.Remove(userToRemove);
        }
    }

    public User GetUserById(int userId)
    {
        return users.Find(u => u.Id == userId);
    }

    public void DisplayUsers()
    {
        foreach (var user in users)
        {
            Console.WriteLine($"User ID: {user.Id}, Name: {user.Name}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Завдання 1: Керування списком завдань
        TaskManager taskManager = new TaskManager();

        Task task1 = new Task { TaskId = 1, Description = "Complete homework" };
        Task task2 = new Task { TaskId = 2, Description = "Prepare presentation" };

        taskManager.AddTask(task1);
        taskManager.AddTask(task2);

        taskManager.DisplayTasks();

        taskManager.RemoveTask(1);

        Console.WriteLine("After removing a task:");
        taskManager.DisplayTasks();

        // Завдання 2: Управління списком користувачів
      UserManager userManager = new UserManager();

        User user1 = new User { Id = 1, Name = "John Doe" };
        User user2 = new User { Id = 2, Name = "Jane Doe" };

        userManager.AddUser(user1);
        userManager.AddUser(user2);

        userManager.DisplayUsers();

        User foundUser = userManager.GetUserById(1);
        Console.WriteLine($"Found user: User ID: {foundUser.Id}, Name: {foundUser.Name}");

        userManager.RemoveUser(2);

        Console.WriteLine("After removing a user:");
        userManager.DisplayUsers();

        Console.ReadLine();
    }
}
