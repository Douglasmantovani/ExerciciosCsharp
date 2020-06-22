using System;
using System.Collections.Generic;

namespace multiplode3 {
    class Program {
        static void Main (string[] args) {
            Console.Clear ();
            
                bool sair;
                int num1;
                do {
                    Console.WriteLine ("PROGRAMA QUE INDENTIFICA OS MULTIPLOS DE 3");
                    System.Console.WriteLine ();
                    
                    System.Console.WriteLine ("Digite um numero ou uma letra para sair");
                    sair = int.TryParse (Console.ReadLine(), out num1);
                    int teste = num1 % 3;
                    if (teste == 0) {
                        System.Console.WriteLine ($"{num1} é multiplo de 3");
                        System.Console.WriteLine ("Pressione enter para continuar");
                        Console.ReadLine ();
                        Console.Clear ();
                    } else {
                        System.Console.WriteLine ("Não é multiplo de 3");
                        System.Console.WriteLine ("Pressione enter para continuar");
                        Console.ReadLine ();
                        Console.Clear ();
                    }
                } while (sair);

                //Estrutura try catch ficou redundante
        

        }
    }
}