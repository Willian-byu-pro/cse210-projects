using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using StreamWriter outputFile = new(filename);
        foreach (var entry in _entries)
        {
            outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            _entries.Add(new Entry(parts[0], parts[1], parts[2]));
        }
    }
}