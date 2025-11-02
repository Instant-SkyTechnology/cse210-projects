using System;
public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine("WORK EXPERIENCES");
        Console.WriteLine("=================================================");
        
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Job: ");

        foreach (Job j in _jobs)
        {
            j.DisplayJobDetails();
        }

        Console.WriteLine("=================================================");
        Console.WriteLine();
    }
}