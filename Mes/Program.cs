using System;

namespace Mes
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            do{
            Console.WriteLine("Digite qualquer numero inteiro de 1 a 12 ou fim para terminar");
            op = Console.ReadLine();
            switch(op){
                case "1":
                System.Console.WriteLine("O número que voce digitou corresponde a Janeiro");
                System.Console.WriteLine("Digite Enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
                case "2":
                System.Console.WriteLine("O número que voce digitou corresponde a Fevereiro");
                System.Console.WriteLine("Digite Enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
                case "3":
                System.Console.WriteLine("O número que voce digitou corresponde a Março");
                System.Console.WriteLine("Digite Enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
                case "4":
                System.Console.WriteLine("O número que voce digitou corresponde a Abril");
                System.Console.WriteLine("Digite Enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
                case "5":
                System.Console.WriteLine("O número que voce digitou corresponde a Maio");
                System.Console.WriteLine("Digite Enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
                    
                case "6":
                System.Console.WriteLine("O número que voce digitou corresponde a Junho");
                System.Console.WriteLine("Digite Enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
                case "7":
                System.Console.WriteLine("O número que voce digitou corresponde a Julho");
                System.Console.WriteLine("Digite Enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
                case "8":
                System.Console.WriteLine("O número que voce digitou corresponde a Agosto");
                System.Console.WriteLine("Digite Enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
                case "9":
                System.Console.WriteLine("O número que voce digitou corresponde a Setembro");
                System.Console.WriteLine("Digite Enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
                case "10":
                System.Console.WriteLine("O número que voce digitou corresponde a Outubro");
                System.Console.WriteLine("Digite Enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
                case "11":
                System.Console.WriteLine("O número que voce digitou corresponde a Novembro");
                System.Console.WriteLine("Digite Enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
                case "12":
                System.Console.WriteLine("O número que voce digitou corresponde a Dezembro");
                System.Console.WriteLine("Digite Enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
                default:
                System.Console.WriteLine("Nâo existe um um mes correspondente para o número que voce digitou");
                System.Console.WriteLine("Digite Enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
                }
                }while(op != "fim");
        }
    }
}
