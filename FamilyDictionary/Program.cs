using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "42" } });

            foreach (var (person, details) in myFamily)
            {
                Console.WriteLine($"This person {person} has these details : ");
                foreach (var detail in details)
                {
                    Console.WriteLine(detail.Key);
                }
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}
