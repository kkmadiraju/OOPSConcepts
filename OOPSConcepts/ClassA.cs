using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OOPSConcepts
{
    internal class ClassA
    {
        static int a = 10;
        public ClassA()
        {
            Console.WriteLine("Constructor of ClassA",a);
        }
        //You cannot have a static constructor with parameters.
        //Static constructors are parameterless and are used to initialize static members of the class.
        //They are called automatically before any instance of the class is created or any static members are accessed.
        //private ClassA()
        //{
        //    Console.WriteLine("Private Constructor of ClassA");
        //}

        static ClassA()
        {
            int a = 1000;
            Console.WriteLine("Static Constructor of ClassA",a);
        }
        public ClassA(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }
    class ClassB: ClassA
    {
        public ClassB()
        {
            
        }
    }
    class ClassC : ClassB
    {
        public ClassC()
        {
            
        }
    }
}
