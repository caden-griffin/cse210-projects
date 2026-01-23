using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
       string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions
       {
           WriteIndented = true
       });

       File.WriteAllText(filename, json);
    }

    public void LoadFromFile(string filename)
    {
        string json = File.ReadAllText(filename);

        _entries = JsonSerializer.Deserialize<List<Entry>>(json);   

        if (_entries == null)
        {
            _entries = new List<Entry>();
        }
    }
}
