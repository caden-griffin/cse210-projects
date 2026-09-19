using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to file");
        using (StreamWriter outputeFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputeFile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}~{entry._mood}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        Console.WriteLine("Reading File");

        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");


            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            newEntry._mood = parts[3];

            _entries.Add(newEntry);

        }
    }
}