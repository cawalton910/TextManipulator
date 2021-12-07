//TextManipulator.cs, Chase Walton
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextManipulator
{

    class TextManipulator
    {
        Random r = new Random();
        public static List<string> list = new List<string>();       //The list of sentences from the text file.

        public TextManipulator()
        {
            try
            {       
                var fileStream = new FileStream(FileRoot.FilePath(), FileMode.Open, FileAccess.Read);           
                using (var streamReader = new StreamReader(fileStream))
                {
                    string line = streamReader.ReadToEnd();                

                    
                    var split = Regex.Split(line, @"(?<=[.,!])");         
                    foreach (var item in split)
                    {
                        list.Add(item);            
                    }          
                }  
                if (list.Count == 0 || list.Count == 1)          
                {
                    throw new Exception("This class cannot be used with only one sentence");
                }
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            RandomSentence = assignSentence();  
        }

        public string RandomSentence { get; set; }    
        public string assignSentence()
        {
            int i = r.Next(0, list.Count-1);
            return list[i].TrimStart(Environment.NewLine.ToCharArray());

        }

        public string randomWord()
        {
            String[] wordsArray = RandomSentence.Split(" ");           
            int i = r.Next(0, wordsArray.Length);
            return wordsArray.ElementAt(i);
        }

        public int countWords()
        {
            String[] wordsArray = RandomSentence.Split(" ");        
            return wordsArray.Length;
        }

        public string removePunctuation()
        {
            return Regex.Replace(RandomSentence, "[.,!]", "");      //Regex expression that replaces a . , or ! with an empty string.
        }

        public Dictionary<char, int> countChars()
        {
            Dictionary<char, int> d1 = new Dictionary<char, int>();
            foreach (char item in RandomSentence)                  
            {
                if (!(char.IsWhiteSpace(item) || item == '.' || item == ',' || item == '!'))       
                {
                    if (!d1.ContainsKey(item))              
                    {
                        d1.Add(item, 1);                   
                    }
                    else                                    
                    {                       
                        d1[item] = (d1[item]) + 1;        
                    }
                }
            }
            return d1;
        }
    }
}
