using System;

namespace PersonalAssistance.TaskManager1
{
    public class AcademicTask : Task
    {
        public string CourseName { get; set; }

        public AcademicTask(string title, string description, DateTime scheduledTime, string courseName)
            : base(title, description, scheduledTime)
        {
            CourseName = courseName;
        }

        public override void DisplayTaskDetails()
        {
            Console.WriteLine($"Academic Task: {Title}, Course: {CourseName}, Scheduled: {ScheduledTime}");
        }
    }
}