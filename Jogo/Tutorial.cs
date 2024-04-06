using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogo
{
    class Tutorial
    {
        public static void TutorialIniciar(CriarPecas[] peca)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Bem vindo ao jogo Galo da Velha");
            Console.WriteLine("");
            
            //descrição
            Console.WriteLine("Descrição:");
            Console.WriteLine("");
            Console.Write("Este é um jogo para dois jogadores. ");
            Console.Write("O tabuleiro tem 16 espaços (4x4) e existem 16 ");
            Console.Write("peças diferentes que podem ser construídas ");
            Console.WriteLine("combinando as quatro características seguintes:");
            Console.ReadLine();
            
            
            //as peças
            Console.WriteLine("As peças cada um tem quatro caracteristicas:");
            Console.WriteLine("Tamanho(grande/pequeno)");
            Console.WriteLine("Cor(clara/escura)");
            Console.WriteLine("Forma(circulo/quadrado)");
            Console.WriteLine("Furo(com/sem)");
            Console.WriteLine("E cada peça tem um simbolo representando:");
            for(int i = 0; i<16 ;i++){
                char simbolo = peca[i].GetPeca();
                string icon = char.ToString(simbolo);

                peca[i].GetCor();
                Console.WriteLine(icon);
            }
            Console.ReadLine();
            Console.Clear();
            //Objetivo
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("O objetivo de cada jogador é fazer uma linha");
            Console.WriteLine(" pode ser vertical, horizontal ou diagonal,");
            Console.Write("com quatro peças que sejam semelhantes em pelo");
            Console.WriteLine(" menos umas das quatro"+
            " caracteristicas referidas.");
            Console.Write("O jogador vence apos colocar");
            Console.Write(" a quarta peça da linha");
            Console.Write(" e empata caso não tenha nenhuma linha feita");
            Console.ReadLine();
            Console.Clear();

            //Regras
            Console.WriteLine("");
            Console.WriteLine("Regras:");

            Console.Write("Os jogadores jogam alternadamente");
            Console.Write(" e cada um coloca uma peça, uma vez colocadas");
            Console.WriteLine(" nao podem ser mexidas");

            Console.Write("A escolha da peça a colocar no tabuleiro");
            Console.Write(" não é feita pelo mesmo jogador que a coloca");
            Console.WriteLine(", é o adversario que escolhe a"+ 
            " peça a ser colocada");

            Console.Write("Essencialmente cada turno consiste em");
            Console.WriteLine(" duas ações:");

            Console.Write("1- Adversario escolhe a peça a ser");
            Console.WriteLine(" colocada pelo jogador atual");

            Console.Write("2- Jogador atual coloca a peça dada ");
            Console.WriteLine(" pelo adversario onde desejar");
            Console.Write("Se a peça colocada pelo jogador atual");
            Console.Write(" completar uma linha de");
            Console.Write(" quatro peças como pelo menos");
            Console.WriteLine(" uma caracteristica semelhante ele vence");
            Console.ReadLine();
            Console.Clear();
            //como jogar
            Console.Write("Quando o jogo iniciar ira aparece um texto");
            Console.Write(" a dizer para o adversario do jogador atual");
            Console.Write(" indicar a peça que vai ser utilizada");
            Console.Write(" e ele tera que indicar um numero de 1 a 16");
            Console.WriteLine(" para indicar a peça");
            Console.Write("Em Seguida o jogador atual diz onde deseja colocar");
            Console.Write(" a peça, para indicar onde colocar a peça é so");
            Console.Write(" indicar a posiçaõ");
            Console.WriteLine("(numero de 1 a 16 a contar a partir" + 
            " do canto superior esquerdo para a direita)");
            Console.ReadLine();
            Console.Clear();

            //perguntar se acabou de ler tudo
            
            Console.Write("Quando tiver lido tudo e achar que esta pronto ");
            Console.Write(" para continuar clique enter");
            Console.ReadLine();
            Console.Clear();
        }
    }
}