using System;
using System.Linq;
using System.Text;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int digitNumber = int.Parse(Console.ReadLine());


            StringBuilder builder = new StringBuilder();
            var onMinde = 0;

            for (int i = line.Length - 1; i >= 0; i--)
            {
                int currentNumber = int.Parse(line[i].ToString());

                int result = digitNumber * currentNumber + onMinde;

                builder.Append(result % 10);

                onMinde = result / 10;
            }
            if (onMinde != 0)
            {
                builder.Append(onMinde);
            }

            string resultNumber = string.Join("", builder.ToString().Reverse()).TrimStart('0');

            if (resultNumber == string.Empty)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(resultNumber);
            }
        }
    }
}
