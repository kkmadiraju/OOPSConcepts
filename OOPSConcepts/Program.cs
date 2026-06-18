using System;

namespace OOPSConcepts
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create instances to demonstrate constructors
            ClassA a1 = new ClassA();
            ClassA a2 = new ClassA(3, 4);
            ClassB b = new ClassB();
            ClassC c = new ClassC();

            Console.WriteLine("Program finished.");
        }
    }
}
