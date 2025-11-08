using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    //INSPIRATION SOURCE VIDEOS POSTED IN CANVAS AND BY THE INSTRUCTOR
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.\n");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                // Save each entry as a line
                outputFile.WriteLine($"{entry._date}__{entry._promptText}__{entry._entryText}");
            }
        }
        Console.WriteLine($"Journal saved to '{file}'.\n");
    }
    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        // _entries.Clear(); // replace current entries
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(" ~ ");
            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry);
            }
        }

        Console.WriteLine($"Journal loaded from '{file}'.\n");
    }
    // public void List<Entry> LoadFromFile()//if not working, to be removed
    // {
    //     public List<Entry> _entries = new List<Entry>();
    //     string file = "journal.txt";

    //     string[] lines = System.IO.File.ReadAllLines(file);
    //     foreach (string line in lines)
    //     {
    //         string[] parts = line.Split(" | ");
    //         if (parts.Length == 3)
    //         {
    //             Entry entry = new Entry();
    //             entry._date = parts[0];
    //             entry._promptText = parts[1];
    //             entry._entryText = parts[2];
    //             _entries.Add(entry);
    //         }
    //     }

    //     Console.WriteLine($"Journal loaded from '{file}'.\n");
    //     return _entries;
    // }
}
