using System;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = Console.ReadLine().Split(", ");


            var contains = true;


            for (int i = 0; i < names.Length; i++)
            {
                var currentName = names[i];
                if (currentName.Length > 3 && currentName.Length < 16)
                {
                    if (currentName.Contains("_") || currentName.Contains("!") || currentName.Contains("@"))
                    {
                        contains = false;
                    }
                    else
                    {
                        Console.WriteLine((currentName));
                    }
                }
            }
        }
    }
}
