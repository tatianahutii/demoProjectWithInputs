using System;

namespace DemoForRunWithInput
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine();
            var secondInput = Console.ReadLine();
            Console.WriteLine($"Length of first line: {firstInput.Length}");
            Console.WriteLine($"Length of second line: {secondInput.Length}");

            Console.WriteLine("Concat result of your input:");
            Console.WriteLine($"{firstInput}{secondInput}");
        }
    }
}
