using System;
using System.Runtime.CompilerServices;

namespace oraimunka
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            string input;
            int num1;
            int num2;
            double result = 0;

            input = Console.ReadLine();
            if (input.Split(" ").Length != 3)
            {
                Console.WriteLine("fuck");
                throw new RuntimeWrappedException("a");
            }

            num1 = int.Parse(input.Split(" ")[1]);
            num2 = int.Parse(input.Split(" ")[2]);
            op = input.Split(" ")[0];

            switch (op)
            {
               case "+":
                   result = num1 + num2;
                   break;
               case "-":
                   result = num1 - num2;
                   break;
               case "*":
                   result = num1 * num2;
                   break;
               case "/":
                   result = (double) (((double) num1) / ((double) num2));
                   break;
            }
            Console.WriteLine(result.ToString());
        }
    }
}