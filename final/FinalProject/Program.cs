using System;
using PersonalAssistance.Services;
using PersonalAssistance.TaskManager1;

namespace PersonalAssistance
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

            taskManager.AddTask(new AcademicTask("Math Study Session", "Study Chapter 5", DateTime.Now.AddMinutes(30), "Mathematics 101"));
            taskManager.AddTask(new SpiritualTask("Morning Prayer", "Pray for guidance and gratitude", DateTime.Now.AddMinutes(15)));

            NotificationService notificationService = new NotificationService(taskManager);

            notificationService.Start();

            Console.WriteLine("AI Personal Assistant is running. Press enter to exit.");
            Console.ReadLine();

            notificationService.Stop();
        }
    }
}