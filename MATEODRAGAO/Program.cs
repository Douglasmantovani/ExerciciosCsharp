using System;
using MATEODRAGAO.Models;

namespace MATEODRAGAO {
    class Program {
        static void Main (string[] args) {

            bool jogadorNaoDesistiu = true;

            do {
                /* INICIO - Menu Principal */
                Console.Clear ();
                System.Console.WriteLine ("===========================");
                System.Console.WriteLine ("       Mate o Dragão!");
                System.Console.WriteLine ("===========================");

                System.Console.WriteLine (" 1 - Iniciar jogo");
                System.Console.WriteLine (" 0 - Sair do jogo");
                System.Console.Write (" Digite o código da opção:");
                string opcaoJogador = Console.ReadLine ();

                /* FIM - Menu Principal */
                switch (opcaoJogador) {
                    case "1":
                        Console.Clear ();
                        System.Console.WriteLine("Escolha o genero");
                        System.Console.WriteLine (" 1 - Masculino");
                        System.Console.WriteLine (" 2 - Feminino");
                        int GeneroJogador = int.Parse(Console.ReadLine());

                        


                        /* INICIO - Criando os personagens (objetos) */
                        Guerreiro guerreiro = new Guerreiro ();
                        guerreiro.Nome = "Maxxor";
                        guerreiro.Sobrenome = "Ragnarson";
                        guerreiro.Genero="Masculino";
                        guerreiro.CidadeNatal = "Póris";
                        guerreiro.DataNascimento = DateTime.Parse ("20/10/1600");
                        guerreiro.FerramentaAtaque = "Espada";
                        guerreiro.FerramentaProtecao = "Escudo";
                        guerreiro.Forca = 3;
                        guerreiro.Destreza = 3;
                        guerreiro.Inteligencia = 2;
                        guerreiro.Vida = 20;

                        Guerreiro guerreira = new Guerreiro ();
                        guerreira.Nome = "Cassandra";
                        guerreira.Sobrenome = "";
                        guerreira.Genero="Masculino";
                        guerreira.CidadeNatal = "Póris";
                        guerreira.DataNascimento = DateTime.Parse ("20/10/1600");
                        guerreira.FerramentaAtaque = "Espada";
                        guerreira.FerramentaProtecao = "Escudo";
                        guerreira.Forca = 3;
                        guerreira.Destreza = 3;
                        guerreira.Inteligencia = 2;
                        guerreira.Vida = 20;

                        Dragao dragao = new Dragao ();
                        dragao.Nome = "Fafnir";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;
                        /* FIM - Criando os personagens (objetos) */
                       if(GeneroJogador==1)
                       {
                            System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: {dragao.Nome}, Prepare-se para morrer!!!");
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:{dragao.Nome},vingarei todas aquelas pessoas que voce matou,colocarei sua cabeça em uma bandeija");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Humano insolente.Apagarei vossa existencia desse mundo\n");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();
                        Console.Clear ();
                        /* FIM - Primeiro Diálogo */

                        /* INICIO - Segundo Diálogo */
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:QUEM É TU MIZERAVI?");
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:Eu sou {guerreiro.Nome}! De {guerreiro.Sobrenome}, Ó criatura das trevas");
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Vim de {guerreiro.CidadeNatal} para derrota-te e me tornar rei apos voltar com a sua cabeça arrancada!");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:  Quem? de onde?nunca nem vi!!!vou te devorar e descarregar minha furia em suas cidades até não sobrar mais nada");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();
                        Console.Clear ();
                       }else if(GeneroJogador==2)
                       { System.Console.WriteLine ($"{guerreira.Nome.ToUpper()}: {dragao.Nome}, Prepare-se para morrer!!!");
                        System.Console.WriteLine ($"{guerreira.Nome.ToUpper()}:{dragao.Nome},vingarei todas aquelas pessoas que voce matou,colocarei sua cabeça em uma bandeija");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Humano insolente.Apagarei vossa existencia desse mundo\n");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();
                        Console.Clear ();
                        /* FIM - Primeiro Diálogo */

                        /* INICIO - Segundo Diálogo */
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:QUEM É TU MIZERAVI?");
                        System.Console.WriteLine ($"{guerreira.Nome.ToUpper()}:Eu sou {guerreira.Nome}! De {guerreira.Sobrenome}, Ó criatura das trevas");
                        System.Console.WriteLine ($"{guerreira.Nome.ToUpper()}: Vim de {guerreira.CidadeNatal} para derrota-te e me tornar rei apos voltar com a sua cabeça arrancada!");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:  Quem? de onde?nunca nem vi!!!vou te devorar e descarregar minha furia em suas cidades até não sobrar mais nada");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();
                        Console.Clear ();

                       }
                        /* INICIO - Primeiro Diálogo */
                       
                        /* FIM - Segundo Diálogo */

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;
                        bool jogadorNaoCorreu = true;

                        /** INICIO - Quando o jogador ataca primeiro */
                        if (jogadorAtacaPrimeiro) {
                            Console.Clear ();

                            System.Console.WriteLine ("------------------------------");
                            System.Console.WriteLine ("        Turno do jogador:");
                            System.Console.WriteLine ("------------------------------");
                            System.Console.WriteLine ("Escolha sua ação");
                            System.Console.WriteLine (" 1 - Atacar");
                            System.Console.WriteLine (" 2 - Fugir");
                            System.Console.Write (" Digite o código da opção:");
                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random ();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = guerreiro.Destreza + numeroAleatorioDragao;
                                    int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Sofra na minha espada criatura das trevas!");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Jogador: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:  Errou otario!");
                                        System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Jogador: {guerreiro.Vida}");
                                    }
                                    break;
                                case "2":
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:Eu voltarei");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Estarei esperando aqui seu verme");
                                    jogadorNaoCorreu = false;
                                    break;
                            }
                            System.Console.WriteLine ();
                            System.Console.WriteLine ("Aperte ENTER para prosseguir");
                            Console.ReadLine ();
                        }

                        /** FIM - Quando o jogador ataca primeiro */

                        /** INICIO - Turnos Oficiais */
                        while (dragao.Vida > 0 && guerreiro.Vida > 0 && jogadorNaoCorreu) {

                            Console.Clear ();
                            System.Console.WriteLine ("------------------------------");
                            System.Console.WriteLine ("       Turno do dragão:");
                            System.Console.WriteLine ("------------------------------");
                            Random geradorNumeroAleatorio = new Random ();
                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                            int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = guerreiro.Destreza + numeroAleatorioDragao;

                            if (guerreiroDestrezaTotal < dragaoDestrezaTotal) {
                                System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Va para o inferno maldito!!!");
                                guerreiro.Vida -= dragao.Forca;
                                System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                System.Console.WriteLine ($"HP Jogador: {guerreiro.Vida}");
                            } else {
                                System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Humano insolente,nao pode me deter!");
                                System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                System.Console.WriteLine ($"HP Jogador: {guerreiro.Vida}");
                            }

                            System.Console.WriteLine ();
                            System.Console.WriteLine ("Aperte ENTER para prosseguir");
                            Console.ReadLine ();

                            Console.Clear ();

                            if (guerreiro.Vida <= 0) {
                                System.Console.WriteLine ("Jogador Falceu!");
                                System.Console.WriteLine ();
                                System.Console.WriteLine ("Aperte ENTER para prosseguir");
                                Console.ReadLine ();
                                break;
                            }
                            System.Console.WriteLine ("------------------------------");
                            System.Console.WriteLine ("       Turno do jogador:");
                            System.Console.WriteLine ("------------------------------");
                            System.Console.WriteLine ("Escolha sua ação");
                            System.Console.WriteLine (" 1 - Atacar");
                            System.Console.WriteLine (" 2 - Fugir");
                            System.Console.Write (" Digite o código da opção:");
                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    geradorNumeroAleatorio = new Random ();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = guerreiro.Destreza + numeroAleatorioDragao;
                                    int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Sofra na minha espada criatura das trevas!!!");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Jogador: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Humano insolente,nao pode me deter!");
                                    }
                                    break;
                                case "2":
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Eu voltarei!");
                                    jogadorNaoCorreu = false;
                                    break;
                            }

                            if (dragao.Vida <= 0) {
                                System.Console.WriteLine ("O monstro foi para o inferno");
                                System.Console.WriteLine ();
                                System.Console.WriteLine ("Aperte ENTER para prosseguir");
                                Console.ReadLine ();
                                break;
                            }

                            System.Console.WriteLine ();
                            System.Console.WriteLine ("Aperte ENTER para prosseguir");
                            Console.ReadLine ();
                        }
                        /** FIM - Turnos Oficiais */

                        break;
                    case "0":
                        jogadorNaoDesistiu = false;
                        break;
                    default:
                        System.Console.WriteLine ("Comando desconhecido");
                        break;

                }

            } while (jogadorNaoDesistiu);

            System.Console.WriteLine ("GAME OVER!");

        }
    }
}