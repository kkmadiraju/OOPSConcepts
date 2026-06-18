using System;

namespace OOPSConcepts
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create instances to demonstrate constructors
            ParentClass a1 = new ParentClass();
            ParentClass a2 = new ParentClass(3, 4);
            FirstChild b = new FirstChild();
            SecondChild c = new SecondChild();

            Console.WriteLine("Program finished.");
        }
    }
}
