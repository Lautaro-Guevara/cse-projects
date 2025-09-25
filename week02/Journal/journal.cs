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

        for (int i = 0; i < _entries.Count(); i++)
        {
            _entries[i].Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file, true))
        {
            for (int i = 0; i < _entries.Count(); i++)
            {
                outputFile.WriteLine($"{_entries[i]._date}-{_entries[i]._promptText}-{_entries[i]._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        Console.WriteLine($"Days from last write: {LastEntryDate(file)}");

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        
    }

    public string LastEntryDate(string file)
    {
        string[] entries = System.IO.File.ReadAllLines(file);

        if (entries.Count() == 0)
        {
            return "No entries available.";
        }
        else
        {
            string lastEntry = entries[entries.Count() - 1];
            string date = lastEntry.Split("-")[0];

            int day = int.Parse(date.Split("/")[0]);
            int month = int.Parse(date.Split("/")[1]);
            int year = int.Parse(date.Split("/")[2]);

            DateTime entryDate = new DateTime(year, month, day);
            DateTime currentDate = DateTime.Now;

            TimeSpan diference = currentDate - entryDate;
            int daysDifference = diference.Days;
            return daysDifference.ToString();
        }
    }
}