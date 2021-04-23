using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input num: ");
            int num = int.Parse(Console.ReadLine());
            int startnum = 1, i, j;
            for (i = 0; i < num; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        startnum = 1;
                    else
                        startnum = startnum * (i - j + 1) / j;
                    Console.Write(startnum + " ");
                }
                Console.WriteLine();
            }
            if (num < 0)
            {
                Console.WriteLine("Invalid Pascal's Triangle");
                Console.Write("input num: ");
                num = int.Parse(Console.ReadLine());
                for (i = 0; i < num; i++)
                {
                    for (j = 0; j <= i; j++)
                    {
                        if (j == 0 || i == 0)
                            startnum = 1;
                        else
                            startnum = startnum * (i - j + 1) / j;
                        Console.Write(startnum + " ");
                    }
                    Console.WriteLine();
                }
            }
            if (num == 0)
                Console.WriteLine("1"); 
        }
    }
}