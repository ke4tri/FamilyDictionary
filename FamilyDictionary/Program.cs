using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates the Dictionary
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            // Adds to the Dictionary
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "42" } });

            string personChoose = " ";
            string personAge = " ";
            // Loops over the Dictionary
            
            Console.WriteLine($"This is the first {personChoose}");
            foreach (var (person, details) in myFamily)
            {
                foreach (var detail in details)
                {
                    if (detail.Value == "Krista")
                    {
                        personChoose = "Krista";
                    }
                    if (detail.Value == "42" )
                    {
                        personAge = "42";
                    }
                }
                
                Console.WriteLine($"{personChoose} is my sister and is {personAge} years old");
            }

            Console.ReadLine();
        }
    }
}
               

                    

