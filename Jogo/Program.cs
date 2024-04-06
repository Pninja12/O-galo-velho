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
            pecas[0] = new CriarPecas(-1,largerOpenBox,
            TipoPecas.Cor|TipoPecas.Tamanho|TipoPecas.Buraco|TipoPecas.Forma);
            pecas[1] = new CriarPecas(-1,openBox,
            TipoPecas.Cor|TipoPecas.Buraco|TipoPecas.Forma);
            pecas[2] = new CriarPecas(-1,largerOpenCircle,
            TipoPecas.Cor|TipoPecas.Tamanho|TipoPecas.Buraco);
            pecas[3] = new CriarPecas(-1,openCircle,
            TipoPecas.Cor|TipoPecas.Buraco);
            pecas[4] = new CriarPecas(-1,largerClosedBox,
            TipoPecas.Cor|TipoPecas.Tamanho|TipoPecas.Forma);
            pecas[5] = new CriarPecas(-1,closedBox,
            TipoPecas.Cor|TipoPecas.Forma);
            pecas[6] = new CriarPecas(-1,largerClosedCircle,
            TipoPecas.Cor|TipoPecas.Tamanho);
            pecas[7] = new CriarPecas(-1,closedCircle,
            TipoPecas.Cor);
            pecas[8] = new CriarPecas(-1,largerOpenBox,
            TipoPecas.Tamanho|TipoPecas.Buraco|TipoPecas.Forma);
            pecas[9] = new CriarPecas(-1,openBox,
            TipoPecas.Buraco|TipoPecas.Forma);
            pecas[10] = new CriarPecas(-1,largerOpenCircle,
            TipoPecas.Tamanho|TipoPecas.Buraco);
            pecas[11] = new CriarPecas(-1,openCircle,
            TipoPecas.Buraco);
            pecas[12] = new CriarPecas(-1,largerClosedBox,
            TipoPecas.Tamanho|TipoPecas.Forma);
            pecas[13] = new CriarPecas(-1,closedBox,
            TipoPecas.Forma);
            pecas[14] = new CriarPecas(-1,largerClosedCircle,
            TipoPecas.Tamanho);
            pecas[15] = new CriarPecas(-1,closedCircle,0);

            //tutorial
            Tutorial.TutorialIniciar(pecas);
            
            //Jogo começa
            jogo(pecas);
        }

        static void jogo(CriarPecas[] todasPecas){
            string[] tabuleiro = new string[16];
            int playeratual = 2;
            int adversario = 1;
            int aserusada = 0;
            int[] pecasusadas = new int [16];

            for(int x=0;x<16;x++){  
                tabuleiro[x] = "-";
                pecasusadas[x] = -1;
            }    
            int ronda = 1;
            bool jg = true;
            while (jg == true)
            {
                int m;
                m= 0;
                //mostrar tabuleiro
                for(int x=0;x<4;x++){  
                    for(int y=0;y<4;y++){ 
                        if(tabuleiro[m] == "-"){
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(tabuleiro[m]);
                        }else{
                            for(int j=0;j<16;j++){  
                                int p = todasPecas[j].GetPosicao() - 1;
                                if(p == m){
                                    todasPecas[j].GetCor();
                                    Console.Write(tabuleiro[m]);
                                }
                            } 
                        }
                        Console.Write(" ");
                        m += 1;
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
                    Console.Write(" (um numero de 1 a 16)\n-->");
                    string aSer = Console.ReadLine();
                    //este metodo try aprendi na escola no 12ºano
                    try{
                        aserusada = int.Parse(aSer)-1;
                        a += 1;
                    } catch{
                        Console.WriteLine("Erro indique um numero");
                        a-=1;
                    }
                    if(aserusada < 0 || aserusada >= 16){
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
                    Console.Write(" (numero de 1 a 16 a contar a partir" + 
                    " do canto superior esquerdo para a direita)\n-->");
                    string pos = Console.ReadLine();
                    int posicao;
                    posicao = 0;
                    try{
                        posicao = int.Parse(pos);
                    } catch{
                        Console.WriteLine("Erro indique um numero");
                        b-=1;
                    }
                    b+=1;
                    if(posicao <= 0 || posicao >= 17 ){
                        Console.WriteLine("Erro numeros so aceites de 1 a 16");
                    }else{
                        
                    }
                    b+=1;
                    //meter o simbolo na posição certa
                    if(tabuleiro[posicao-1] == "-"){
                        tabuleiro[posicao-1] = todasPecas[aserusada].GetPeca().
                        ToString(); 
                        todasPecas[aserusada].SetPosicao(posicao);
                        
                    }else{
                        Console.WriteLine("Erro Posição ja tem peça");
                        b-=1;
                    }
                    b+=1;
                }

                if (Fim.VerificarFim(todasPecas)){
                    jg = false;
                   Console.WriteLine($"player {playeratual} ganhou!!");
                };
                pecasusadas[ronda] = aserusada;
                ronda +=1;


                



                
            }
            
        }

    }
}
