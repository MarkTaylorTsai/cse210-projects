using System;

namespace PersonalAssistance.TaskManager1
{
    public abstract class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ScheduledTime { get; set; }

        protected Task(string title, string description, DateTime scheduledTime)
        {
            Title = title;
            Description = description;
            ScheduledTime = scheduledTime;
        }

        public abstract void DisplayTaskDetails();
    }
}