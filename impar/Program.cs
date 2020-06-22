using System;

namespace impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Digite um numero ou 0 para sair");
            i = int.Parse(Console.ReadLine());
            
            if(i%2 == 0){
                System.Console.WriteLine("é par");
            }else{
                System.Console.WriteLine("é impar");
            } 
            
        }
    }
}
