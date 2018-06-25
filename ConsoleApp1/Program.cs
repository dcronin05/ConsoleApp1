using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            var john = new Person();
            // john.FirstName = "Daniel";
            john.LastName = "Cronin";
            // Console.WriteLine(john.FirstName);
            // john.Introduce();

            Person.FirstName = "John";
            Person.Introduce();

            Console.ReadKey();
        }
    }

    public class Calculator
    {
        static public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class Person
    {
        public static string FirstName;
        public string LastName;

        public static void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + Calculator.Add(1, 3));
        }
    }
}
