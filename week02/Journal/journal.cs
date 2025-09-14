using System.IO;

public class Journal{

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry){

        _entries.Add(newEntry);

    }

    public void DisplayAll(){

        for (int i = 0; i < _entries.Count(); i++)
        {
            _entries[i].Display();
        }
    }

    public void SaveToFile(string file){
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            for (int i = 0; i < _entries.Count(); i++)
            {
                outputFile.WriteLine($"{_entries[i]._date} - {_entries[i]._promptText}");
                outputFile.WriteLine($"{_entries[i]._entryText}");
                outputFile.WriteLine("");
            }
        }
    }

    public void LoadFromFile(string file){
        
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}