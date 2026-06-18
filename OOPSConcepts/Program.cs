using System;

namespace OOPSConcepts
{
    class Program
    {
        class A
        {
            public A()
            {
                Console.WriteLine("Constructor of class A");
            }
        }
        class B : A
        {
            public B()
            {
                Console.WriteLine("Constructor of class B");
            }
        }
        class C : B
        {
            public C()
            {
                Console.WriteLine("Constructor of class C");
            }
        }   
        class D : A
        {
            public D()
            {
                Console.WriteLine("Constructor of class D");
            }
        }
        public static void Main(string[] args)
        {
            // Create instances to demonstrate constructors
            ParentClass a1 = new ParentClass();
            ParentClass a2 = new ParentClass(3, 4);
            FirstChild firstChild = new FirstChild();
            SecondChild secondChild = new SecondChild();

            
            A a = new A();//a
            B b = new B(); //b
            A c = new B();//b
            B d = (B)new A(); //Not Allowed //You need to cast the object of type A to type B explicitly,
                              //but this will throw an InvalidCastException at runtime because an instance of A cannot be cast to B.
            Console.WriteLine("Program finished.");
        }   
    }

}
