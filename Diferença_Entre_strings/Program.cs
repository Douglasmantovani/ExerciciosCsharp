using System;

namespace Diferença_Entre_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao comparador de frases.Lembre-se de colocar o mesmo numero de palavras em ambos.Divirta-se!!!");
            Console.WriteLine("Digite uma frase");
            string texto1=Console.ReadLine();
            Console.WriteLine("Digite outra frase");
            string texto2=Console.ReadLine();
            string textoFinal1;
            string textoFinal2;
            if(texto1!=texto2){
                string[] textoquebrado1=texto1.Split(' ');
                string[] textoquebrado2=texto2.Split(' ');
                if(textoquebrado1.Length==textoquebrado2.Length){
                for(int i=0;i<textoquebrado1.Length;i++){
                    if(textoquebrado1[i]!=textoquebrado2[i]){
                         textoquebrado1[i]="["+textoquebrado1[i]+"]";
                         textoquebrado2[i]="["+textoquebrado2[i]+"]";
                    }
                }
                textoFinal1=String.Concat(textoquebrado1);
                textoFinal2=String.Concat(textoquebrado2);
                Console.WriteLine("As diferenças nos textos estarão marcadas com []");
                Console.WriteLine("Frase 1:"+textoFinal1);
                Console.WriteLine("Frase 2:"+textoFinal2);
                }else{
                    Console.WriteLine("Os textos não estão no padrão solicitado");
                }
            }else{
                Console.WriteLine("Os textos estão iguais");
            }
        }
    }
}
