using System;

namespace Prof
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[12];
            double maior = 0;
            double menor = 0;
            for(int i = 0; i < 12; i++){
                Console.WriteLine($"Digite a temperatura do mes {i+1}: ");
                temperaturas[i] = double.Parse(Console.ReadLine());
            }
            maior = temperaturas[0];
            menor = temperaturas[0];
            
            foreach ( var temp in temperaturas)
            {
                if(temp > maior){
                    maior = temp ;
                    } else if(temp < menor){
                        menor = temp;
                    }
                
                }
                Console.WriteLine($"A maior temperatura é {maior}");
                Console.WriteLine($"A menor temperatura é {menor}");
            
        }
    }
}
