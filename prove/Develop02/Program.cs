using System;

class Display
{
    static void Main(string[] args)
    {
        
        string userSelection ="";
        Entry entry = new();
        Journal nowjournal = new();
        bool journalSaved = true;
        do
        {
            Console.WriteLine("\nPlease select : a. Write b. Display c. Save d. Load e. Quit");
            
            
            userSelection= Console.ReadLine();
            Console.WriteLine();
            switch (userSelection)
            {
                case "a": 
                    entry.WriteJournal(nowjournal);
                    journalSaved = false; 
                    break;
                case "b": 
                    nowjournal.ReadJournal();
                    break;
                case "c": 
                    nowjournal.SaveEntries();
                    journalSaved = true; 
                    break;
                case "d": 
                    Console.WriteLine("What file would you like to load? Make sure you save brfore doing this! Enter \"c\" to cancel ");
                    string fileName = Console.ReadLine();
                    if (fileName == "c")
                    {
                        break;
                    }
                    else 
                    {
                        nowjournal = nowjournal.LoadJournal(fileName);
                        Console.WriteLine($"{fileName} loaded");
                        break;
                    }
                case "e": 
                    if (journalSaved == false) 
                    {
                        bool validAnswer;
                        do
                        {
                            Console.Write("Current journal is not saved. Would you like to save? (yes/no): ");
                            string saveBeforeExiting = Console.ReadLine();
                            switch (saveBeforeExiting)
                            {
                                case "yes":
                                    nowjournal.SaveEntries();
                                    validAnswer = true;
                                    break;
                                case "no":
                                    validAnswer = true;
                                    break;
                                default:
                                    Console.WriteLine("Invalid option. Do it again\n");
                                    validAnswer = false;
                                    break;
                            }
                        } while (validAnswer == false);
                    }
                    break;
                default: 
                    Console.WriteLine("Invalid entry.");
                    break;
            }


        } while (userSelection != "e"); 
    }  
}