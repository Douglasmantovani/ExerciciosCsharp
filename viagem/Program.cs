using System;

namespace viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quilometros deseja percorrer?");
            double destino = double.Parse(Console.ReadLine());
            System.Console.WriteLine($"A quantos km/h vai andar?");
            double velocidade = double.Parse(Console.ReadLine());
            double distancia = destino * velocidade;
            System.Console.WriteLine($"A distancia é {distancia}");
            double gasolina = distancia/12;
            System.Console.WriteLine($"A gasolina gasta nessa viagem é de:{gasolina}");
        }
    }
}
