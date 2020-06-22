using System;

namespace Planetas
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            do{
            
            Console.WriteLine("Programa que calcula seu peso em outros planetas ou digite fim");
            System.Console.WriteLine();
            System.Console.WriteLine("1-Mercurio");
            System.Console.WriteLine("2-Venus");
            System.Console.WriteLine("3-Marte");
            System.Console.WriteLine("4-Jupter");
            System.Console.WriteLine("5-Saturno");
            System.Console.WriteLine("6-Urano");
            op = Console.ReadLine();
            
            
                    switch(op){
                    case "1":
                    System.Console.WriteLine("Digite seu peso na terra");
                    double peso1 = double.Parse(Console.ReadLine());
                    peso1 = peso1 / 9.8;
                    System.Console.WriteLine($"Seu peso em Mercurio é:{peso1*0.37}");
                    System.Console.WriteLine("Pressione enter para contunuar");
                    Console.ReadLine();
                    break;
                    case "2":
                    System.Console.WriteLine("Digite seu peso na terra");
                    double peso2 = double.Parse(Console.ReadLine());
                    peso2 = peso2 / 9.8;
                    System.Console.WriteLine($"Seu peso em Venus é:{peso2*0.88}");
                    System.Console.WriteLine("Pressione enter para contunuar");
                    Console.ReadLine();
                    break;
                    case "3":
                    System.Console.WriteLine("Digite seu peso na terra");
                    double peso3 = double.Parse(Console.ReadLine());
                    peso3 = peso3 / 9.8;
                    System.Console.WriteLine($"Seu peso em Marte é:{peso3*0.38}");
                    System.Console.WriteLine("Pressione enter para contunuar");
                    Console.ReadLine();
                    break;
                    case "4":
                    System.Console.WriteLine("Digite seu peso na terra");
                    double peso4 = double.Parse(Console.ReadLine());
                    peso4 = peso4 / 9.8;
                    System.Console.WriteLine($"Seu peso em Jupter é:{peso4*2,64 }");
                    System.Console.WriteLine("Pressione enter para contunuar");
                    Console.ReadLine();
                    break;
                    case "5":
                    System.Console.WriteLine("Digite seu peso na terra");
                    double peso5 = double.Parse(Console.ReadLine());
                    peso5 = peso5 / 9.8;
                    System.Console.WriteLine($"Seu peso em Saturno é:{peso5*1,15 }");
                    System.Console.WriteLine("Pressione enter para contunuar");
                    Console.ReadLine();
                    break;
                    case "6":
                    System.Console.WriteLine("Digite seu peso na terra");
                    double peso6 = double.Parse(Console.ReadLine());
                    peso6 = peso6 / 9.8;
                    System.Console.WriteLine($"Seu peso em Urano é:{peso6* 1,17}");
                    System.Console.WriteLine("Pressione enter para contunuar");
                    Console.ReadLine();
                    break;
                    default:
                    System.Console.WriteLine("Comando invalido");
                    System.Console.WriteLine("Pressione enter para contunuar");
                    Console.ReadLine();
                    break;
                    }
                }while(op !="fim");//problema de looping no while
        }
    }
}
