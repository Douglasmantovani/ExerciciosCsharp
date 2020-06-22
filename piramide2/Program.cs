using System;

namespace piramide2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Qual a altura do triangulo?");
            int altura = int.Parse(Console.ReadLine());
            int largura = altura;
            for(int i = 0; i < altura; i++){
                for(int j = 0; j < largura; j++){
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
                largura--;
            }
        }
    }
}
