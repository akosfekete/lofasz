using System;

namespace gyak02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> firstNullable = null;
            int? secondNullable = null;

            if (firstNullable.HasValue)
            {
                Console.WriteLine(firstNullable.Value);
            }
            else
            {
                firstNullable = 2;
            }
            Console.WriteLine(firstNullable.Value);
            Console.WriteLine(secondNullable);
            secondNullable= 12;
            Console.WriteLine(secondNullable);

            var anonim = new {id = 2, name = "asd"};
            Console.WriteLine(anonim);
        }
    }
}