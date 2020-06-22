using System.Numerics;
using System;

namespace nomes
{
    class Program
    {
        static void Main(string[] args)
        {  

            
            string[] nomes = new string[2];
            for(int nom = 0;nom <=1;nom++ ){
                Console.WriteLine("Digite um nome");
                nomes[nom] = Console.ReadLine();
            }
            Array.Sort(nomes);
            foreach(string x in nomes){
                System.Console.WriteLine(x);
            }
            
            

            
            

        }
    }
}
