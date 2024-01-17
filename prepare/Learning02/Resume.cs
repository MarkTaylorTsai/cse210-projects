using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public Resume(string name)
    {
        _name = name;
    }
    public void addJob(Job job)
    {
        _jobs.Add(job);
    }

    public void _Display()
    {
        Console.WriteLine($"{_name}");
        foreach (Job job in _jobs)
        {
            job._Display();
        }
    }
}