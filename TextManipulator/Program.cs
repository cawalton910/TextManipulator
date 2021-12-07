//Program.cs, Chase Walton
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextManipulator
{
    class Program
    {
        public static TextManipulator t = new TextManipulator();            
        static void Main(string[] args)
        {         
            while (true)            
            {
                Console.Clear();
                Menu();
            }
        }

        static void Menu()
        {
            Console.WriteLine("-----Menu-----");
            Console.WriteLine("Select an option (1-7)");
            Console.WriteLine("1. Display random sentence");
            Console.WriteLine("2. Assign new random sentence from any .txt file or string");
            Console.WriteLine("3. Display random word from the random sentence");
            Console.WriteLine("4. Display count of words from the random sentence");
            Console.WriteLine("5. Remove punctuation from the random sentence");
            Console.WriteLine("6. Display number of times each character is used in dictionary");
            Console.WriteLine("7. Exit the program");
            int intSelection;
            
            while (true)               //Input validation
            {
                String userSelection = Console.ReadLine();
                if (int.TryParse(userSelection, out intSelection) & intSelection < 8)       
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a number 1-7: ");                      
                }
            }
            Console.Clear();

            switch (intSelection)                                                          
            {
                case 1: 
                    Console.WriteLine("Random sentence: " + t.RandomSentence);         
                    Console.WriteLine("\nPress enter to continue");
                    Console.ReadLine();
                    break;

                case 2:
                    t.RandomSentence = t.assignSentence();                              
                    Console.WriteLine("Assigned the random sentence: " + t.RandomSentence);     
                    Console.WriteLine("\nPress enter to continue");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Random word: " + t.randomWord());                
                    Console.WriteLine("\nPress enter to continue");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("Number of words in sentence: " + t.countWords());            
                    Console.WriteLine("\nPress enter to continue");
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("Without punctuation: " + t.removePunctuation());           
                    Console.WriteLine("\nPress enter to continue");
                    Console.ReadLine();
                    break;

                case 6:
                    Dictionary<char, int> d2 = new Dictionary<char, int>();
                    d2 = t.countChars();                                        
                    foreach (var item in d2)
                    {
                        Console.WriteLine(item);           
                    }
                    Console.WriteLine("\nPress enter to continue");
                    Console.ReadLine();
                    break;

                case 7:
                    Console.WriteLine("Thank you for using my program!");
                    Console.WriteLine("Press enter to exit");
                    Console.ReadLine();
                    System.Environment.Exit(1);            
                    break;
            }
        }
    }
}
