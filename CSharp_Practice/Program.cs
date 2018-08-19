using System;

namespace CSharp_Practice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string thing = "movie";
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite " + thing + "?");
            string favoriteThing = Console.ReadLine();

            Console.WriteLine("just changin' -- not! booyah");
            Console.WriteLine("My name is " + name + " and my favorite " + thing + " is " + favoriteThing + ".");
        }
    }
}
