using System;

namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            // Obtidos pela a ajuda do Copilot
            char openBox = '\u25A1'; // Open box
            char closedBox = '\u25AA'; // Closed box
            char largerOpenBox = '\u2610'; // Larger open box
            char largerClosedBox = '\u25A0'; // Larger closed box
            char openCircle = '\u25CB'; // Open circle
            char closedCircle = '\u25CF'; // Closed circle
            char largerOpenCircle = '\u25EF'; // Larger open circle
            char largerClosedCircle = '\u2B24'; // Larger closed circle
            
            //Console.ForegroundColor = ConsoleColor.Brown;
            //Console.ForegroundColor = ConsoleColor.White;

            CriarPecas[] pecas = new CriarPecas [16];
            pecas[0] = new CriarPecas(0,largerOpenBox,
            TipoPecas.Cor|TipoPecas.Tamanho|TipoPecas.Buraco|TipoPecas.Forma);
            pecas[1] = new CriarPecas(0,openBox,
            TipoPecas.Cor|TipoPecas.Buraco|TipoPecas.Forma);
            pecas[2] = new CriarPecas(0,largerOpenCircle,
            TipoPecas.Cor|TipoPecas.Tamanho|TipoPecas.Buraco);
            pecas[3] = new CriarPecas(0,openCircle,
            TipoPecas.Cor|TipoPecas.Buraco);
            pecas[4] = new CriarPecas(0,largerClosedBox,
            TipoPecas.Cor|TipoPecas.Tamanho|TipoPecas.Forma);
            pecas[5] = new CriarPecas(0,closedBox,
            TipoPecas.Cor|TipoPecas.Forma);
            pecas[6] = new CriarPecas(0,largerClosedCircle,
            TipoPecas.Cor|TipoPecas.Tamanho);
            pecas[7] = new CriarPecas(0,closedCircle,
            TipoPecas.Cor);
            pecas[8] = new CriarPecas(0,largerOpenBox,
            TipoPecas.Tamanho|TipoPecas.Buraco|TipoPecas.Forma);
            pecas[9] = new CriarPecas(0,openBox,
            TipoPecas.Buraco|TipoPecas.Forma);
            pecas[10] = new CriarPecas(0,largerOpenCircle,
            TipoPecas.Tamanho|TipoPecas.Buraco);
            pecas[11] = new CriarPecas(0,openCircle,
            TipoPecas.Buraco);
            pecas[12] = new CriarPecas(0,largerClosedBox,
            TipoPecas.Tamanho|TipoPecas.Forma);
            pecas[13] = new CriarPecas(0,closedBox,
            TipoPecas.Forma);
            pecas[14] = new CriarPecas(0,largerClosedCircle,
            TipoPecas.Tamanho);
            pecas[15] = new CriarPecas(0,closedCircle,0);

            ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
            //tutorial

            //como funciona
            Console.WriteLine("Este jogo funciona da seguinte forma:");
            Console.WriteLine("");
            Console.WriteLine("Isto é um jogo de 2 jogadores um contra um.");
            Console.WriteLine("Existem 16 peças diferentes e um tabuleiro 4x4.");
            Console.ReadLine();
            //as peças
            Console.WriteLine("As peças cada um tem quatro caracteristicas:");
            Console.WriteLine("Tamanho(grande/pequeno)");
            Console.WriteLine("Cor(clara/escura)");
            Console.WriteLine("Forma(circulo/quadrado)");
            Console.WriteLine("Furo(com/sem)");
            Console.WriteLine("E cada peça tem um simbolo representando:");
            for(int i = 0; i<16 ;i++){
                char simbolo = pecas[i].GetPeca();
                string icon = char.ToString(simbolo);

                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(icon, Console.ForegroundColor);
            }
            Console.ReadLine();

            //Objetivo
            Console.Write("O objetivo de cada jogador é fazer uma linha");
            Console.WriteLine(" pode ser vertical, horizontal ou diagonal,");
            Console.Write("com quatro peças que sejam semelhantes em pelo");
            Console.WriteLine(" menos umas das quatro caracteristicas referidas.");
            Console.Write("O jogador vence apos colocar");
            Console.Write(" a quarta peça da linha");
            Console.Write(" e empata caso não tenha nenhuma linha feita");
            Console.ReadLine();

            //Regras
            Console.WriteLine("");
            Console.WriteLine("Regras:");

            Console.Write("Os jogadores jogam alternadamente");
            Console.Write(" e cada um coloca uma peça, uma vez colocadas");
            Console.WriteLine(" nao podem ser mexidas");

            Console.Write("A escolha da peça a colocar no tabuleiro");
            Console.Write(" não é feita pelo mesmo jogador que a coloca");
            Console.WriteLine(", é o adversario que escolhe a peça a ser colocada");

            Console.Write("Essencialmente cada turno consiste em");
            Console.WriteLine(" duas ações:");

            Console.Write("1- Adversario escolhe a peça a ser");
            Console.WriteLine(" colocada pelo jogador atual");

            Console.Write("2- Jogador atual coloca a peça dada ");
            Console.WriteLine(" pelo adversario onde desejar");
            Console.Write("Se a peça colocada pelo jogador atual");
            Console.Write(" completar uma linha de quatro peças como pelo menos");
            Console.WriteLine(" uma caracteristica semelhante ele vence");
            Console.ReadLine();
            //perguntar se acabou de ler tudo
            
            Console.Write("Quando tiver lido tudo e achar que esta pronto ");
            Console.Write(" para continuar clique enter");
            Console.ReadLine();


            //Jogo começa

            //Mostrar tabuleiro atual
            string[,] jogo = new string[4,4];
            for(int x=0;x<4;x++){  
					for(int y=0;y<4;y++){  
						Console.Write(jogo[x,y]+"-");
					}  
					Console.WriteLine(); 
				} 
            Console.ReadLine();
            

        }
    }
}
