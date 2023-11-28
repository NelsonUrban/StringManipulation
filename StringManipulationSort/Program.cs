using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringManipulation
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------RESULT----------------------");
           
            int N = 2;
            List<string> strings = new() { "abaccadcc", "xyzxy" };

            List<string> output = SortingOperations(strings);

            foreach (string outp in output)
            {
                Console.WriteLine(outp);
            }

            Console.WriteLine("--------------------Finish----------------------");
        }
        public static List<string> SortingOperations(List<string> strings)
        {
            List<string> result = new();

            if (!strings.Any()) throw new Exception("You should send a List of strings");

            for (int i = 0; i < strings.Count; i++)
            {
                string s = strings[i];

                // Counting the frequency of each character in the string
                Dictionary<char, int> charFrequency = s.GroupBy(c => c)
                                       .ToDictionary(g => g.Key, g => g.Count());           

                // Sort the characters based on frequency and lexicographical order
                List<char> sortedChars = charFrequency.Keys.OrderByDescending(c => charFrequency[c])
                                                      .ThenBy(c => c)
                                                      .ToList();
                // Create the sorted string
                string sortedString = new(sortedChars.SelectMany(c => Enumerable.Repeat(c, charFrequency[c])).ToArray());

                result.Add(sortedString);
            }

            return result;
        }
    }
}
