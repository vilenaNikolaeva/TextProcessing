using System;
using System.Collections.Generic;
using System.Text;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<char> charList = new List<char>();
            var count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                charList.Add(line[i]);
            }
            for (int i = 1; i <charList.Count; i++)
            {
                char previous = charList[i - 1];
                char current = charList[i];
                if (current==previous)
                {
                    charList.Remove(current);
                    i--;
                }
            }
            Console.WriteLine(string.Join("",charList));
        }
    }
}
