using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "3n+1";
            UInt64 infinite = 1;
            while(infinite < UInt64.MaxValue)
            {
                UInt64 result = infinite;
                Console.Write($"#{infinite} : ");
                do
                {
                    result = calc(result);
                    Console.Write($"{result},");
                } while (result > 1);
                infinite++;
                Console.WriteLine("\n\n");
            }
            Console.ReadLine();
        }

        static UInt64 calc(UInt64 num)
        {
            if (num % 2 == 0) return num / 2;
            else return (3 * num) + 1;
        }
    }
}
