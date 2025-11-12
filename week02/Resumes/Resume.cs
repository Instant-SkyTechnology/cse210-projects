using System;
public class Resume
{
    public string _name;
    public string _lastName;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine("WORK EXPERIENCES");
        Console.WriteLine("=================================================");
        
        Console.WriteLine($"Name: {_name} {_lastName}");
        Console.WriteLine("Job: ");

        foreach (Job j in _jobs)
        {
            j.DisplayJobDetails();
        }

        Console.WriteLine("=================================================");
        Console.WriteLine();
    }
}