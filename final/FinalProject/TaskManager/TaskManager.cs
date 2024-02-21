using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalAssistance.TaskManager1
{
    public class TaskManager
    {
        private List<Task> tasks;

        public TaskManager()
        {
            tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
            Console.WriteLine("Task added successfully.");
        }

        public void RemoveTask(string title)
        {
            var taskToRemove = tasks.FirstOrDefault(t => t.Title == title);
            if (taskToRemove != null)
            {
                tasks.Remove(taskToRemove);
                Console.WriteLine("Task removed successfully.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        public void ListAllTasks()
        {
            Console.WriteLine("Listing all tasks:");
            foreach (var task in tasks)
            {
                task.DisplayTaskDetails();
            }
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return tasks;
        }

    }
}