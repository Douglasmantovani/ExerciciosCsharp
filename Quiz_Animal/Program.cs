using System;
using System.Collections.Generic;
using Quiz_Animal;

namespace QuizAnimasi
{
    class Program
    {
        public static List<Animal>Animais{get;set;}
        static void Main(string[] args)
        {
             bool Encerrar = false;
            string[] Classes = new string[] { "Aéreo", "Terrestre", "Aquático" };
            Console.WriteLine("Bem vindo ao quiz de animais");
            Animais = new List<Animal>(){
                    new Animal{
                        Nome="Águia real",
                        Classe="Aéreo",
                        Atributos=new List<string>(){
                            "Tem Penas",
                            "É da amazonia",
                            "É carnívoro"
                        },
                    },
                    new Animal{
                        Nome="Onça pintada",
                        Classe="Terrestre",
                        Atributos=new List<string>(){
                            "É rapido",
                            "É do brasil",
                            "É carnívoro",
                            "É da cor amarela"
                        }
                    },
                    new Animal{
                        Nome="Tubarão",
                        Classe="Aquático",
                        Atributos=new List<string>(){
                            "É rapido",
                            "Tem barbatanas",
                            "É carnívoro",
                            "É grade"
                        }
                    }
                };
            do
            {
                string response = "";
                string Resposta = "";
                for (int i = 0; i < Classes.Length; i++)
                {
                    System.Console.WriteLine("É:" + Classes[i] + "? Pressione S para sim e X para não");
                    response = Console.ReadLine();
                    if (response == "S" || response == "s")
                    {
                        Resposta = Classes[i];
                        break;
                    }
                }

                if (Resposta.Length > 3)
                {
                    if (Resposta == "Aéreo")
                    {
                        response = "";
                        bool Terminou = false;
                        List<Animal> animaisAreos = Animais.FindAll(s => s.Classe == "Aéreo");
                        for (int i = 0; i < animaisAreos.Count; i++)
                        {
                                int RespostasCorretas = 0;
                                int incoorretas = 0;
                            for (int o = 0; o < animaisAreos[i].Atributos.Count; o++)
                            {
                                System.Console.WriteLine(animaisAreos[i].Atributos[o] + "?Digite S para sim e X Para não");
                                response = Console.ReadLine();
                                if (response == "S" || response == "s")
                                    RespostasCorretas++;

                                else
                                    incoorretas++;

                                if (RespostasCorretas >= 2)
                                {
                                    System.Console.WriteLine("É um(a):" + animaisAreos[i].Nome + "?Digite S para sim e X Para não");
                                    response = Console.ReadLine();
                                    if (response == "S" || response == "s")
                                    {
                                        Terminou = true;
                                        break;
                                    }else{
                                        break;
                                    }
                                }
                                if (incoorretas >= 2)
                                    break;
                            }
                            if (Terminou == true)
                            {
                                break;
                            }
                        }

                        if (Terminou != true)
                        {
                            AdicionarNovoAnimal();
                        }
                    }

                    else if (Resposta == "Terrestre")
                    {
                        response = "";
                        bool Terminou = false;
                        List<Animal> animaisTerrestre = Animais.FindAll(s => s.Classe == "Terrestre");
                        for (int i = 0; i < animaisTerrestre.Count; i++)
                        {
                            int RespostasCorretas = 0;
                            int incoorretas = 0;
                            for (int o = 0; o < animaisTerrestre[i].Atributos.Count; o++)
                            {
                                System.Console.WriteLine(animaisTerrestre[i].Atributos[o] + "?Digite S para sim e X Para não");
                                response = Console.ReadLine();
                                if (response == "S" || response == "s")
                                    RespostasCorretas++;

                                else
                                    incoorretas++;

                                if (RespostasCorretas >= 2)
                                {
                                    System.Console.WriteLine("É um(a):" + animaisTerrestre[i].Nome + "?Digite S para sim e X Para não");
                                    response = Console.ReadLine();
                                    if (response == "S" || response == "s")
                                    {
                                        Terminou = true;
                                        break;
                                    }else{
                                        break;
                                    }
                                }
                                if (incoorretas >= 2)
                                    break;
                            }
                            if (Terminou == true)
                            {
                                break;
                            }
                        }

                        if (Terminou != true)
                        {
                            AdicionarNovoAnimal();
                        }
                    }

                    else if (Resposta == "Aquático")
                    {
                        response = "";
                        bool Terminou = false;
                        List<Animal> animaisAquaticos = Animais.FindAll(s => s.Classe == "Aquático");
                        for (int i = 0; i < animaisAquaticos.Count; i++)
                        {
                            int RespostasCorretas = 0;
                            int incoorretas = 0;
                            for (int o = 0; o < animaisAquaticos[i].Atributos.Count; o++)
                            {
                                System.Console.WriteLine(animaisAquaticos[i].Atributos[o] + "?Digite S para sim e X Para não");
                                response = Console.ReadLine();
                                if (response == "S" || response == "s")
                                    RespostasCorretas++;

                                else
                                    incoorretas++;

                                if (RespostasCorretas >= 2)
                                {
                                    System.Console.WriteLine("É um(a):" + animaisAquaticos[i].Nome + "?Digite S para sim e X Para não");
                                    response = Console.ReadLine();
                                    if (response == "S" || response == "s")
                                    {
                                        Terminou = true;
                                        break;
                                    }else{
                                        break;
                                    }
                                }
                                if (incoorretas >= 2)
                                    break;
                            }
                            if (Terminou == true)
                            {
                                break;
                            }
                        }

                        if (Terminou != true)
                        {
                            AdicionarNovoAnimal();
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine("Classe não encontrada");
                }
                System.Console.WriteLine("Quer encerrar? Digite S para sim e x para não");

                response = Console.ReadLine();
                if (response == "S" || response == "s")
                    Encerrar = true;
                else 
                Encerrar=false;
            } while (Encerrar == false);   
        }
        public static void AdicionarNovoAnimal(){
            System.Console.WriteLine("Qual o nome do animal que voce estava pensando?");
            string Nome = Console.ReadLine();
            System.Console.WriteLine("Qual a classe?");
            string Classe = "";
            Console.WriteLine("1-Aéreo");
            Console.WriteLine("2-Terrestre");
            Console.WriteLine("3-Aquático");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
            case 1:Classe = "Aéreo";
                break;

            case 2:
                 Classe = "Terrestre";
                 break;

            case 3:
                Classe = "Aquático";
                break;

            default:
                Classe="";
                break;
            }
            if (Classe.Length > 2)
            {
                List<string> atrib = new List<string>();
                for (int i = 0; i < 3; i++)
                {
                    System.Console.WriteLine("Digite3 atributos que o diferencia dos demais");
                    atrib.Add(Console.ReadLine());
                }
                Animais.Add(new Animal { Nome = Nome, Classe = Classe, Atributos = atrib });
            }
        }
    }
}
