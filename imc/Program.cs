using System;


namespace imc
{
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
            double peso;
            double altura;
            double IMC;
            string sair ="n";
            do{
            System.Console.WriteLine("Calculadora de IMC");
            System.Console.WriteLine();
            Console.WriteLine("Digite Seu peso corporal");
            peso = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite sua altura");
            altura = double.Parse(Console.ReadLine());
            IMC = peso / (Math.Pow(altura,2));
            IMC = IMC * 10000;
            System.Console.WriteLine(IMC);
            if(IMC <=20 )
            {
                System.Console.WriteLine("Abaixo do peso");
            }
            else if (IMC>20 && IMC <25){
                System.Console.WriteLine("Peso normal");
            }
            else if(IMC >25 && IMC <30){
                System.Console.WriteLine("Excesso de peso");
            }
            else if(IMC >30 && IMC <35){
                System.Console.WriteLine("Obeso");
            }
            else{
                System.Console.WriteLine("Obesidade morbida");
            }
                }while(sair == "n");
            }catch(Exception)
                {
                    System.Console.WriteLine("So aceita numeros ");
                }
        }
    }
}
