using System;
using System.Text;
using System.IO;

namespace Jogo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
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


            Fim.VerificarFim(pecas);
            ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues
            (typeof(ConsoleColor));
            //tutorial

            //como funciona
            Console.WriteLine("Este jogo funciona da seguinte forma:");
            Console.WriteLine("");
            Console.WriteLine("Isto é um jogo de 2 jogadores um contra um.");
            Console.WriteLine("Existem 16 peças diferentes e um tabuleiro 4x4");
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
            Console.Write(" completar uma linha de");
            Console.Write(" quatro peças como pelo menos");
            Console.WriteLine(" uma caracteristica semelhante ele vence");
            Console.ReadLine();
            //como jogar
            Console.Write("Quando o jogo iniciar ira aparece um texto");
            Console.Write(" a dizer para o adversario do jogador atual");
            Console.Write(" indicar a peça que vai ser utilizada");
            Console.Write(" e ele tera que indicar um numero de 1 a 16");
            Console.WriteLine(" para indicar a peça");
            Console.Write("Em Seguida o jogador atual diz onde deseja colocar");
            Console.Write(" a peça, para indicar onde colocar a peça é so");
            Console.Write(" indicar a posiçaõ");
            Console.WriteLine(" linha primeiro em seguida coluna");
            Console.Write("Por exemplo 24 (linha 2 coluna 4)");

            //perguntar se acabou de ler tudo
            
            Console.Write("Quando tiver lido tudo e achar que esta pronto ");
            Console.Write(" para continuar clique enter");
            Console.ReadLine();


            //Jogo começa
            jogo(pecas);

            

        }

        static void jogo(CriarPecas[] todasPecas){
            string[,] tabuleiro = new string[4,4];
            int playeratual = 2;
            int adversario = 1;
            int aserusada = 0;
            int[] pecasusadas = new int [15];
            for(int x=0;x<4;x++){  
                for(int y=0;y<4;y++){  
                    tabuleiro[x,y] = "-";
                }  
            }    
            int ronda = 1;
            while (true)
            {
                //mostrar tabuleiro
                for(int x=0;x<4;x++){  
                    for(int y=0;y<4;y++){  
                        Console.Write(tabuleiro[x,y]);
                    }  
                    Console.WriteLine(); 
                }       
                //Pedir a peça a ser utilizada 
                if (playeratual == 1) {
                    playeratual = 2;
                    adversario = 1;
                }else{
                    playeratual = 1;
                    adversario = 2;
                }
                int a = 0;
                a = 0;
                //pedir ao adversario do player atual para escolher a peça
                //com validações
                while (a != 3){
                    a=0;
                    Console.WriteLine($"Turno do player {playeratual} -");
                    Console.Write($"Player {adversario} diga a peça");
                    Console.Write(" que vai ser usada");
                    Console.Write($" pelo player {playeratual}");
                    Console.Write(" (um numero de 1 a 16)");
                    string aSer = Console.ReadLine();
                    //este metodo try aprendi na escola no 12ºano
                    try{
                        aserusada = int.Parse(aSer);
                        a += 1;
                    } catch{
                        Console.WriteLine("Erro indique um numero");
                        a-=1;
                    }
                    if(aserusada <= 0 || aserusada >= 17){
                        Console.WriteLine("Erro numero nao dentro" + 
                        " dos paramentros");
                    }else{
                        a += 1;
                        
                    };
                    for(int i = 0; i < pecasusadas.Length; i++){
                        if(pecasusadas[i] == aserusada){
                        Console.WriteLine("Erro numero ja foi utilizado");
                        a-=1;
                        }
                    }
                    a += 1;
                }
                int b = 0;
                b = 0;
                //pedir ao player atual para escolher a posição da peça 
                //com validações
                while (b != 3){
                    b=0;
                    
                    Console.Write($"Player {playeratual} diga a posição");
                    Console.Write(" que vai colocar a peça");
                    Console.Write(" (linha primeiro coluna segundo ex: 24)");
                    string posicao = Console.ReadLine();
                    int n = 0;
                    n = 0;
                    int L = 0;
                    int C = 0;
                    try{
                       
                       foreach (char p in posicao){
                        if (n == 0){
                            L = int.Parse(p.ToString()) - 1;
                            n += 1;
                        }else if(n==1){
                            C = int.Parse(p.ToString()) - 1;
                            n +=1 ;
                        }
                        
                    } 
                    }catch{
                        b-=1;
                    }
                    b+=1;
                    if(L<0||L>3||C<0||C>3 ){
                        Console.WriteLine("Erro numeros so aceites de 1 a 4");
                    }else{
                        
                    }
                    b+=1;
                    //meter o simbolo na posição certa
                    if(tabuleiro[L,C] == "-"){
                        tabuleiro[L,C] = todasPecas[aserusada].GetPeca().
                        ToString(); 
                        
                    }else{
                        Console.WriteLine("Erro Posição ja tem peça");
                        b-=1;
                    }
                    b+=1;
                }

                pecasusadas[ronda] = aserusada;
                ronda +=1;


                



                
            }
            
        }

    }
}
