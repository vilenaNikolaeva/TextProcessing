using System;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            int bomb = 0;
            var bombSymbol = '>';

            for (int i = 0; i < line.Length; i++)
            {
                
                if (bomb>0 && line[i]!=bombSymbol)
                {
                    line = line.Remove(i, 1);
                    bomb--;
                    i--;
                }
                else if (line[i]==bombSymbol)
                {
                    bomb += int.Parse(line[i + 1].ToString());
                }
            }
            Console.WriteLine(line);
        }
    }
}
