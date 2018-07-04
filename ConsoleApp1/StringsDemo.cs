using System;

namespace ConsoleApp1
{
    class StringsDemo
    {

        static String firstName = "Mosh";
        static Int32 aNumber = 1000;
        static string lastName = "Hamedani";
        

        public static void Strings()
        {
            var fullName = string.Format("His name is {0} {1}", firstName, lastName);

            var names = new string[] { "Daniel", "Cronin" };

            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";

            Console.WriteLine(string.Format(
                @"{0}
{1}
{2}
{3}", firstName, fullName, string.Join(", ", names), text));
        }

    }
}
