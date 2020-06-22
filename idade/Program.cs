using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
           int anoatual = 2019;
           int anonasc = 0 ;
           int idade;

           Console.WriteLine("Qual ano vc nasceu ?");
           anonasc = int.Parse(Console.ReadLine());
           idade = anoatual - anonasc;

           Console.WriteLine("sua idade atual é de " + idade +"anos");



                           if(idade <=2){
                            Console.WriteLine("recen nascido");    
                        }else if((idade <11) && (idade >=3)){
                            Console.WriteLine("criança");    
                        }else if((idade <19) && (idade >=12)){
                            Console.WriteLine("adolescente");    
                        }else if((idade <65) && (idade >=20)){
                            Console.WriteLine("adulto");    
                        }else if(idade >65){
                            Console.WriteLine("velhote");    

                          
                       
                            
                        }


        }
    }

    }                    
        
