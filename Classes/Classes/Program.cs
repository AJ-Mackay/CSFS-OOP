using System;

namespace Classes
{
    class Employee
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee Dave = new Employee();
            Dave.Age = 35;
            Console.WriteLine("Dave's age is {0}", age);
        }
    }
}