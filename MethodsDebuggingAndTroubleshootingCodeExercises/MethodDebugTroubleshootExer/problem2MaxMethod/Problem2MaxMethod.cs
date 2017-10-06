using System;
namespace problem2MaxMethod
{
    class Problem2MaxMethod
    {
        static void GetMax(int a, int b, int c)
            {
            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
            }

        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            int thrtNum = int.Parse(Console.ReadLine());
            GetMax(firstNum, secNum, thrtNum);
        }
    }
}
