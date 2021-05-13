using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            int x = 1;
            int y = 2;
            int result = x + y;

            System.Console.WriteLine(result);

            var numbers = new[] { 1, 2, 3, 4 };

            var result2 = 0;
            foreach (var number in numbers)
            {
                result2 += number;
            }
            System.Console.WriteLine(result2);

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
