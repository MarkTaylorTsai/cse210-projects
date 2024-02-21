using System;

namespace PersonalAssistance.TaskManager1
{
    public class SpiritualTask : Task
    {
        public SpiritualTask(string title, string description, DateTime scheduledTime)
            : base(title, description, scheduledTime)
        {
        }

        public override void DisplayTaskDetails()
        {
            Console.WriteLine($"Spiritual Task: {Title}, Scheduled: {ScheduledTime}");
        }
    }
}