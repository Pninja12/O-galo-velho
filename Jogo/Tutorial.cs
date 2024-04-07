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
            //inicio
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Bem vindo ao jogo Galo da Velha!\n");

            //descrição
            Console.WriteLine("Descrição:\n");
            Console.Write("Este é um jogo para dois jogadores. ");
            Console.Write("O tabuleiro tem 16 espaços (4x4) e existem 16 ");
            Console.Write("peças diferentes que podem ser construídas ");
            Console.Write("combinando as quatro características seguintes:\n");
            Console.WriteLine("-Tamanho (grande/pequena);");
            Console.WriteLine("-Cor (vermelho/azul);");
            Console.WriteLine("-Forma (círculo/quadrado);");
            Console.WriteLine("-Furo (com/sem).\n");

            //mostra os símbolos no ecrã
            Console.WriteLine("Cada peça é representada por um símbolo:");
            for(int i = 0; i<8 ;i++){
                char simbolo = peca[i].GetPeca();
                string icon = char.ToString(simbolo);
                peca[i].GetCor();
                Console.Write(icon+ " ");
            }
            Console.WriteLine("");
            for(int i = 8; i<16 ;i++){
                char simbolo = peca[i].GetPeca();
                string icon = char.ToString(simbolo);
                peca[i].GetCor();
                Console.Write(icon+ " ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            Console.WriteLine("Clique Enter para continuar...");
            Console.ReadLine();
            Console.Clear();

            //objetivo
            Console.WriteLine("Objetivo:");
            Console.WriteLine("");
            Console.Write("O objetivo do jogo é completar uma linha com ");
            Console.Write("quatro peças que sejam semelhantes em pelo menos");
            Console.Write(" uma das suas quatro características (tamanho,cor,");
            Console.WriteLine(" forma ou furo);");
            Console.Write("A linha pode ser vertical, horizontal ou diagonal;");
            Console.Write("\nO vencedor é o jogador que colocar a quarta ");
            Console.WriteLine("peça da linha;");
            Console.Write("O jogo termina em empate quando ninguém ");
            Console.WriteLine("atinge o objetivo após colocação das 16 peças.");
            Console.WriteLine("");
            Console.WriteLine("Clique Enter para continuar...");
            Console.ReadLine();
            Console.Clear();

            //regras
            Console.WriteLine("Regras do Jogo:");
            Console.WriteLine("");
            Console.Write("Os jogadores jogam alternadamente, ");
            Console.Write("colocando uma peça no tabuleiro.");
            Console.Write(" Uma vez colocadas, as peças não podem voltar");
            Console.WriteLine(" a ser movidas.");
            Console.Write("A escolha da peça a colocar no tabuleiro  não é ");
            Console.Write("feita pelo mesmo jogador que a coloca, ");
            Console.Write("é o adversário que decide qual será");
            Console.WriteLine(" a peça seguinte a colocar.");
            Console.WriteLine("Assim, cada jogada consiste em duas ações:");
            Console.Write("1. Adversário escolhe peça a ser colocada");
            Console.WriteLine(" pelo jogador atual;");
            Console.Write("2. Jogador atual coloca no tabuleiro");
            Console.WriteLine(" a peça dada pelo adversário.");
            Console.WriteLine("");
            Console.Write("Se a peça colocada pelo jogador atual fizer uma ");
            Console.Write("linha de quatro peças com pelo menos uma ");
            Console.Write("característica semelhante (tamanho, cor, ");
            Console.WriteLine("forma ou furo), esse jogador vence.");
            Console.WriteLine("");
            Console.WriteLine("Clique Enter para continuar...");
            Console.ReadLine();
            Console.Clear();

            //como jogar
            Console.WriteLine("Como Jogar:");
            Console.WriteLine("");
            Console.Write("Quando o jogo iniciar, irá aparecer um texto");
            Console.Write(" a dizer para o adversário");
            Console.Write(" indicar a peça que vai ser utilizada, inserindo ");
            Console.WriteLine("um número de 1 a 16 correspondente à peça.");
            Console.Write("Em Seguida o jogador atual deve inserir o número ");
            Console.Write("de 1 a 16 correspondente à posição ");
            Console.WriteLine("onde deseja colocar a peça.");
            Console.WriteLine("");
            Console.WriteLine("Clique Enter para começar o jogo...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}