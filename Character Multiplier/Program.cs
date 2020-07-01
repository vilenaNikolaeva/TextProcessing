using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            string firstInput = input[0];
            string lastInput = input[1];

            var maxLenght = string.Empty;
            var minLenght = string.Empty;
            var result = 0;

            if (firstInput.Length > lastInput.Length)
            {
                maxLenght = firstInput;
                minLenght = lastInput;
            }
            else
            {
                maxLenght = lastInput;
                minLenght = firstInput;
            }
            var totalSum = 0;
            for (int i = 0; i < minLenght.Length; i++)
            {
                totalSum += minLenght[i] * maxLenght[i];
            }
            for (int i = minLenght.Length; i < maxLenght.Length; i++)
            {
                totalSum += maxLenght[i];
            }
            Console.WriteLine(totalSum);
        }
    }
}
