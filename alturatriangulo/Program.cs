using System;

namespace alturatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a base do triangulo");
            int b1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a altura do retangulo");
            int a1= int.Parse(Console.ReadLine());
            int areaRet = b1 * a1 /2;
            Console.WriteLine("A área do Retângulo é " + areaRet); 


            int periretangulo =a1+b1*2;
            System.Console.WriteLine($"O perimetro do triangulo é:{periretangulo}");
            int diagonalaltat = a1 ^ 2;
            int diagonalbd = b1 ^2;
            int diagonal = diagonalaltat + diagonalbd ^2;
            System.Console.WriteLine($"A diagonal é {diagonal}"); 

        }
    }
}
