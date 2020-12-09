using System;
using System.Security.Cryptography;
using System.Text;

namespace opa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto");
            var text= Console.ReadLine();
            var cry=Cryptho(text);
            Console.WriteLine(cry);
        }

        //Retorna um hash em SHA256
        private static string Cryptho(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            System.Security.Cryptography.SHA256 MinhaHasher = System.Security.Cryptography.SHA256.Create();
            byte[] hash = MinhaHasher.ComputeHash(bytes);
            string NomeHash = string.Empty;
            foreach (byte x in hash)
            {
                NomeHash += string.Format("{0:x2}", x);//Quanto maior o numero maior o tamanho da hash
            }
            return NomeHash;
        }

        //Retorna um hash criptografado em MD5
        public static string Criptografador(string text)
        {
            MD5 myHash = MD5.Create();

            byte[] Data = myHash.ComputeHash(Encoding.UTF8.GetBytes(text));

            StringBuilder stb = new StringBuilder();

            for(int i = 0; i < Data.Length; i++)
            {
                stb.Append(Data[i].ToString("x3"));//Quanto maior o numero maior o tamanho da hash
            }
            return stb.ToString();
        }
    }
}
