using System;

namespace dinheiro
{
    class Program
    {
        static void Main(string[] args)

        {
            double salario;
            double aumento;

            Console.Write("valor do seu cheque:");
            salario = double.Parse(Console.ReadLine());
            #region Codigo
            if (salario<500){
               aumento = salario * 0.3;
               salario += aumento;
               Console.WriteLine("parabens leva 50");
               Console.WriteLine("seu novo salario é "+ salario);}
            #endregion
               else {
                   Console.WriteLine("Desculpe vc ja tem o suficente");
               }
        


        }
    }
}
