﻿using System;

namespace hanoirecursioncsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            result = fact(7);
            Console.WriteLine("Factorial is: " + result);
            Console.ReadLine();
            
        }
        public static int fact(int num)
        {
            if (num == 0)
                return 1;
            return num * fact(num - 1);
        }
    }
}
