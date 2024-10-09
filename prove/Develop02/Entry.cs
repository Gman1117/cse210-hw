public class Entry
{
    
    public string _date;
    public string _prompt;
    public string _entry;


    
    static string SelectPrompt()
    {
        Random random = new();
        List<string> prompts = ["What are your most Greatful for today?", "How did you see God today?", "How did you become better today?"];
        int promptselction = random.Next(prompts.Count);
        string prompt = prompts[promptselction];
        return prompt;
    }
    public void WriteJournal(Journal nowjournal)
    {
        Entry entry =new();
        entry._prompt = SelectPrompt(); 


        Console.WriteLine(entry._prompt);
        entry._entry = Console.ReadLine();


        DateTime currentDateTime = DateTime.Now; 
        entry._date = currentDateTime.ToShortDateString();


        nowjournal._entries.Add(entry); 
    }
}
