using System;
using PersonalAssistance.TaskManager1;
using Timer = System.Timers.Timer;
using System.Timers;

namespace PersonalAssistance.Services
{
    public class NotificationService
    {
        private readonly TaskManager taskManager;
        private Timer notificationTimer;

        public NotificationService(TaskManager taskManager)
        {
            this.taskManager = taskManager;
            notificationTimer = new Timer(60000);
            notificationTimer.Elapsed += CheckForUpcomingTasks;
            notificationTimer.AutoReset = true;
            notificationTimer.Enabled = true;
        }

        private void CheckForUpcomingTasks(object sender, ElapsedEventArgs e)
        {
            var now = DateTime.Now;
            foreach (var task in taskManager.GetAllTasks())
            {
                var timeUntilTask = task.ScheduledTime - now;
                if (timeUntilTask <= TimeSpan.FromMinutes(15) && timeUntilTask > TimeSpan.Zero)
                {
                    Console.WriteLine($"Reminder: '{task.Title}' is scheduled in {timeUntilTask.Minutes} minutes.");
                }
            }
        }

        public void Start()
        {
            notificationTimer.Start();
            Console.WriteLine("Notification service started.");
        }

        public void Stop()
        {
            notificationTimer.Stop();
            Console.WriteLine("Notification service stopped.");
        }
    }
}
