using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        Triangel(x);
    }
    static void Triangel(int x)
    {
        for (int i = x; i >0; i--)
        {
            for (int j = i-1; j >0; j--)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            int k = x - i;
            for (int p = 0; p <=2*k-1; p++)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}