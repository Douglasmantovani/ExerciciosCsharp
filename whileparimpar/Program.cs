﻿using System;

namespace whileparimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
        
            while(num != 0){
                Console.Write("Diga um número ou zero para terminar: ");
                num = int.Parse(Console.ReadLine());
                if (num != 0){
                    if (num % 2 == 0){
                        Console.WriteLine("O número é par");
                    } else {
                        Console.WriteLine("O número é impar");
                    }
                }
            }
        }
    }
}
