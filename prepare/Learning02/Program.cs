using System;

class Program
{
    static void Main(string[] args)
    {
        Job teacher = new Job();

        teacher._company = "Apple";
        teacher._jobTitle = "Teacher";
        teacher._startYear = 2025;
        teacher._endYear = 2099;

        teacher._Display();

        Resume person1 = new Resume("Mark Tsai");
        person1.addJob(teacher);

        person1._Display();

    }
}