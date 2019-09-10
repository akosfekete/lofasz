using System;

namespace gyak02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double variable = 3.14;
            double another = variable;

            another = 2;
            
            Console.WriteLine(variable);
            Console.WriteLine(another);
            
            
            
            var rf = new RefType();

            RefType anotherRefType = rf;
            anotherRefType.valueType = 2.71;

            Console.WriteLine(rf.valueType);

        }
    }

    class RefType
    {
        public double valueType = 123.0;
        
        public int MyProperty { get; set; }

        public int MyProperty2
        {
            get { return MyProperty2;}
            set { MyProperty2 = value; }
        }
    }
    
   // Extension method 
   
    public static class StringReverser {
        public static string Reverse(this string input) {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
    }
    
    
}