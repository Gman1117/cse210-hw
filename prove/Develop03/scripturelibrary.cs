public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;
    private const string DEFAULT_FILENAME = "scriptures.txt";

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
    }

    public void LoadFromFile(string filename = DEFAULT_FILENAME)
    {
        try
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException($"Scripture file '{filename}' not found.");
            }

            string[] lines = File.ReadAllLines(filename);
            
            foreach (string line in lines)
            {
                try
                {
                    string[] parts = line.Split('|');
                    if (parts.Length != 2)
                    {
                        Console.WriteLine($"Skipping invalid line format: {line}");
                        continue;
                    }

                    string referenceText = parts[0].Trim();
                    string scriptureText = parts[1].Trim();

                    // Parse the reference (e.g., "1 Nephi 3:7" or "Alma 32:21")
                    string[] refParts = referenceText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    
                    // Handle books with multiple words (e.g., "1 Nephi")
                    string book;
                    int lastWordIndex;
                    
                    if (refParts[0].Any(char.IsDigit))
                    {
                        // Case for "1 Nephi", "2 Nephi", "3 Nephi", etc.
                        book = $"{refParts[0]} {refParts[1]}";
                        lastWordIndex = 2;
                    }
                    else
                    {
                        // Case for "Alma", "Moroni", etc.
                        book = refParts[0];
                        lastWordIndex = 1;
                    }

                    // Get chapter and verse
                    string[] chapterVerse = refParts[lastWordIndex].Split(':');
                    int chapter = int.Parse(chapterVerse[0]);
                    
                    Reference reference;
                    if (chapterVerse[1].Contains('-'))
                    {
                        // Handle verse ranges (e.g., "5-6")
                        string[] verses = chapterVerse[1].Split('-');
                        reference = new Reference(book, chapter, 
                            int.Parse(verses[0]), int.Parse(verses[1]));
                    }
                    else
                    {
                        // Handle single verses
                        reference = new Reference(book, chapter, 
                            int.Parse(chapterVerse[1]));
                    }

                    _scriptures.Add(new Scripture(reference, scriptureText));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error parsing scripture: {ex.Message}");
                    continue;
                }
            }

            Console.WriteLine($"Successfully loaded {_scriptures.Count} scriptures.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading scripture file: {ex.Message}");
            throw;
        }
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            throw new InvalidOperationException("No scriptures loaded. Please ensure the scripture file is properly loaded.");
        }
        return _scriptures[_random.Next(_scriptures.Count)];
    }

    public int GetScriptureCount()
    {
        return _scriptures.Count;
    }

    public void DisplayAllScriptures()
    {
        if (_scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures loaded.");
            return;
        }

        Console.WriteLine("\nAvailable Scriptures:");
        Console.WriteLine("--------------------");
        for (int i = 0; i < _scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_scriptures[i].GetDisplayText()}\n");
        }
    }
}

