using System;

namespace Rabota1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x:");
            int x = int.Parse(Console.ReadLine());
            int y = 5 * x + 20;
            y *= 2;
            Console.WriteLine($"Результат выражения y = {y}");
        }
    }
}
