using System;

namespace Extraxt_FIle
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splitedInput = input.Split("\\");
            string currentString = splitedInput[splitedInput.Length-1];

            string fileName = currentString.Substring(0, currentString.LastIndexOf('.'));
            string fileExtension = currentString.Substring(currentString.LastIndexOf('.') + 1);
            
            Console.WriteLine($"File Name: {fileName}");
            Console.WriteLine($"File Extension: {fileExtension}");
        }
    }
}
