   using System;
 

   namespace Bytebank {

   
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("cadastro de usuarios ");   
            Console.WriteLine();
            Console.Write("Nome: ");
            string Nome= Console.ReadLine();       
            Console.Write("CPF: ");
            string CPF= Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine(); 

            Cliente cliente = new Cliente(Nome,CPF,Email);

            do {
                Console.WriteLine("Digite a senha");
                string senha =  Console.ReadLine();
                bool senhaok = cliente1.trocasenha(senha);
                if (!senhaok)
                {
                    Console.WriteLine("semha nao atende os requisitos");

                }
                else {
                    Console.WriteLine("senha trocada com sucesso");

                }
               }while(!senhaok);
                
            

            

            }
        }
    }

