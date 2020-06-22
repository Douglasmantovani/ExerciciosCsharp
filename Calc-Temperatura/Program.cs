using System;

namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {   System.Console.WriteLine("Conversor de celcius para farenheith");
            Console.WriteLine("Digite a temperatura que deseja converter");
            double C = int.Parse(Console.ReadLine());
            double F = (C*9)/5+32;
            System.Console.WriteLine($"A temperatura é :{F} fahrenheit");


        }
    }
}
