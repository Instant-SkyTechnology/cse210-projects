using System;

public class Entry
{
    //INSPIRATION SOURCE VIDEOS POSTED IN CANVAS AND BY THE INSTRUCTOR
    public string _date;
    public string _promptText;
    public string _entryText;


    public Entry(string prompt, string entry)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = prompt;
        _entryText = entry;
    }

    public Entry()
    {
        _date = "Unknown Date";
        _promptText = "Unknown Prompt";
        _entryText = "Unknown Entry";
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}