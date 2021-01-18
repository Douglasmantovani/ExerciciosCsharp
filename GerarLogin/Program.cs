using System;
using System.Collections.Generic;

namespace GerarLogin
{
    class Program
    {
        public static List<string> NomesDeUsuario { get; set; }
        static void Main(string[] args)
        {
            try
            {
                NomesDeUsuario = new List<string>(){
                "Douglas20",
                "Douglas10",
                "Douglas2001"
                };
                bool Encerrou = false;
                do
                {
                    Console.WriteLine("Bem vindo ao gerador de Login");
                    System.Console.WriteLine("Digite seu nome completo");
                    string NomeCompleto = Console.ReadLine();
                    System.Console.WriteLine("Digite a sua data de nascimento com /");
                    string DataDeNasc = Console.ReadLine();
                    System.Console.WriteLine("Digite seu Email");
                    string Email = Console.ReadLine();
                    System.Console.WriteLine("Digite seu nome de usuário");
                    string NomeDeUsuario = Console.ReadLine();
                    var BuscarNomeDeUsuario = NomesDeUsuario.Find(u => u == NomeDeUsuario);
                    if (BuscarNomeDeUsuario == null)
                    {
                        Console.WriteLine("Login adicionado");
                        NomesDeUsuario.Add(NomeDeUsuario);
                    }
                    else
                    {
                        Console.WriteLine("Já exixte um usuario com este nome");
                        var resposta = GerarLogin(NomeCompleto, DataDeNasc, Email);
                        Console.WriteLine("Nomes sugeridos");
                        for (int i = 0; i < resposta.Length; i++)
                        {
                            Console.WriteLine(resposta[i]);
                        }
                    }
                    Console.WriteLine("Quer gerar outro?Se sim pressione S senão qualquer outra tecla");
                    var response = Console.ReadLine();
                    if (response == "S" || response == "s")
                        Encerrou = true;
                    else
                    Encerrou=false;
                } while (Encerrou == true);
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu alguma excessão");
            }
        }
        public static string[] GerarLogin(string Nome, string DataDeNasc, string Email)
        {
            string[] NomeSeparado = Nome.Split(' ');
            string[] DataSeparada = DataDeNasc.Split('/');
            string[] EmailSeparado = Email.Split('@');
            string NomeGeradoEmailData;
            string NomeGeradoNomeEmail;
            string NomeGeradoDataNome;
            do
            {

                NomeGeradoEmailData = EmailSeparado[new Random().Next(0, 0)] + DataSeparada[new Random().Next(1, DataSeparada.Length)]+new Random().Next(0,100000);
                NomeGeradoNomeEmail = EmailSeparado[new Random().Next(0, 0)] + NomeSeparado[new Random().Next(1, NomeSeparado.Length)];
                NomeGeradoDataNome = NomeSeparado[new Random().Next(1, NomeSeparado.Length)] + DataSeparada[new Random().Next(1, DataSeparada.Length)];
            } while (NomeGeradoEmailData == NomesDeUsuario.Find(u => u == NomeGeradoEmailData) ||
                    NomeGeradoDataNome == NomesDeUsuario.Find(u => u == NomeGeradoDataNome) ||
                    NomeGeradoNomeEmail == NomesDeUsuario.Find(u => u == NomeGeradoEmailData));
            return new string[] { NomeGeradoDataNome, NomeGeradoEmailData, NomeGeradoNomeEmail };
        }
    }
}
