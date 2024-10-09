using System.Runtime.CompilerServices;

public class Journal
{
    
    public List<Entry> _entries = new ();
    public string _file;

    public void SaveEntries()
    {
      
        if (string.IsNullOrEmpty(_file))
        {
            Console.Write("Please provide a file name: ");
            _file = Console.ReadLine();
        }
       
        if (File.Exists(_file))
        {
           
            bool validOption;
            do
            {
                Console.Write("A file with this name already exists. Do you wish to 1. Overwrite file, 2. Append to file, or 3. Cancel? ");
                string saveOption = Console.ReadLine();
                if (int.TryParse(saveOption, out int saveOptionInt)) 
                {
                    switch (saveOptionInt)
                    {
                        case 1: 
                            
                            using (StreamWriter outputFile = new StreamWriter(_file))
                            {
                                File.WriteAllText(_file, string.Empty);
                            }
                            
                            foreach (Entry entry in _entries)
                            {
                                using (StreamWriter outputFile = new StreamWriter(_file, append: true))
                                {
                                    outputFile.Write($"{entry._date}|{entry._prompt}|{entry._entry}~");
                                }
                            }
                        break;
                        case 2:
                            foreach (Entry entry in _entries)
                            {
                                using (StreamWriter outputFile = new StreamWriter(_file, append: true))
                                {
                                    outputFile.Write($"{entry._date}|{entry._prompt}|{entry._entry}~"); 
                                }
                            }
                        break;
                        case 3: 
                            Console.WriteLine("Save cancelled");
                            break;
                        default:
                            Console.WriteLine("Invalid option. Save aborted");
                            break;
                    }
                    validOption = true;
                }
                
                else 
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    validOption = false;
                }
            } while (validOption == false);
        }
        
        else
        {
            foreach (Entry entry in _entries)
            {
                using (StreamWriter outputFile = new StreamWriter(_file, append: true))
                {
                    outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}~");
                }
            }
        }
    }

    public Journal LoadJournal(string fileName)
    {
        Journal loadedJournal = new Journal();
        loadedJournal._file = fileName;

        string[] lines = File.ReadAllLines(fileName); 
        foreach (string line in lines)
        {
            string[] rawEntry = line.Split("~"); 
            foreach (string entryString in rawEntry)
            {
                Entry entry = new Entry();
                string[] parsedString = entryString.Split("|"); 
                if(parsedString[0] != "") 
                {
                entry._date = parsedString[0];
                entry._prompt = parsedString[1];
                entry._entry = parsedString[2];
                loadedJournal._entries.Add(entry);
                }
            }
        }
        return loadedJournal;
    }
    public void ReadJournal()
    {
        int entryCount = this._entries.Count;
        for (int i = 0; i < entryCount; i++)
        {
            Console.WriteLine($"\n({this._entries[i]._date})| {this._entries[i]._prompt}");
            Console.WriteLine($"{this._entries[i]._entry}\n");
        }
    }
}