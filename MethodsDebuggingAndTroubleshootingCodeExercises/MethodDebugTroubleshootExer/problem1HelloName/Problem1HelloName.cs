using System;
namespace problem1HelloName
{
    class Problem1HelloName
    {
        static void printName(string b , string a)
        {
            Console.WriteLine($"{b} {a}!");
        }
        static void Main()
        {
            string name = Console.ReadLine();
            string pozdrav = "Hello,";
            printName(pozdrav,name);
        }
    }
}
