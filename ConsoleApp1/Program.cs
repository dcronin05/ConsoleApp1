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

            var number = new int[4];

            number[0] = 1;
            number[1] = 2;
            number[2] = 3;

            var flags = new bool[3] { true, false, true };

            Console.Write( flags[1] );
            Console.Write( flags[2] );

            Console.WriteLine(number[0]);

            var avNum = new int();
            var avNUm2 = number[1];

            Console.WriteLine(string.Format("{1}, {0}", avNum, avNUm2));

            Console.WriteLine(string.Format("{0} : {1} : {2}", number[0], number[1], number[2]));

            Console.WriteLine("----------------------------------------------------------");

            StringsDemo.Strings();

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
