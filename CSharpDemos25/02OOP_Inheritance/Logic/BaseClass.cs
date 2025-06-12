using System;

namespace _02OOP_Inheritance.Logic
{
    public class BaseClass
    {
        public void MethodA() 
        {
            Console.WriteLine("Base class Method A");
        }
        public string MethodA(string msg)// Method Overloadding withing same class
        {
            return msg;
        }
    }
    public class DerivedClass : BaseClass
    {
        // Method Overloadding withing acress the classes
        public new void MethodA() // Shadowing
        {
            Console.WriteLine("Derived class Method A");
        }
    }
}
