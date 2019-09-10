using System;

namespace gyak02_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var rf = new RefType();
            DoMagic(rf);
        }

        static public void DoMagic(RefType r)
        {
            //r.valueType = 0;
            r = new RefType();
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
}