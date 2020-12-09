using System;
using System.IO;
using System.Text;

namespace MovendoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Move os arquivos de  local
             var Origem="Origem/";
             var Destino="Destino";
             var NomeDoArquivo="/bigBoss.jpg";
              var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), Origem+NomeDoArquivo);
              var pathMove = Path.Combine(Directory.GetCurrentDirectory(),Destino+NomeDoArquivo);
             System.IO.File.Move(pathToSave, pathMove, true);
             

            //Renomeia arquivos para dateTime(serve para evitar conflitos de nomes)
             string teste=DateTime.Now.ToString("ddMMyyyyHHmmss");
             //Pega o valor da extensao
             string Extensao = Origem.Split('.')[1].Trim();
             teste=teste+"."+Extensao;
             Console.WriteLine(teste);
              string sourceFile =Path.Combine(Directory.GetCurrentDirectory(), Origem+NomeDoArquivo);  
             string source =Path.Combine(Directory.GetCurrentDirectory(), Origem);  
             System.Console.WriteLine(source);
              // Create a FileInfo  
              System.IO.FileInfo fi = new System.IO.FileInfo(sourceFile);   
              //Renomeia o arquivo passando o diretório
             fi.MoveTo(source+teste);  
             Console.WriteLine("Arquivo renomeado."); 
        }
    }
}
