using System;
using System.Text;
using System.IO;

namespace Jogo
{
    /// <summary>
    /// Programa que corre o jogo, tutorial e a verificação da vitória
    /// </summary>
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

            //tutorial
            Tutorial.TutorialIniciar(pecas);
            
            //Jogo começa
            jogo(pecas);
        }

        /// <summary>
        /// Class onde o jogo corre
        /// </summary>
        /// <param name="todasPecas">Recebe todas as peças do jogo</param>
        static void jogo(CriarPecas[] todasPecas){
            string[] tabuleiro = new string[16];
            int playeratual = 2;
            int adversario = 1;
            int aserusada = 0;
            int[] pecasusadas = new int [16];
            int empate = 0;
            //fazer o tabuleiro aparecer com "-"
            for(int x=0;x<16;x++){  
                tabuleiro[x] = "-";
                pecasusadas[x] = -1;
            }    
            int ronda = 1;
            bool jg = true;

            //loop do jogo
            while (jg == true)
            {
                int m;
                m= 0;
                Console.Clear();
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
                //mostrar peças restantes 
                empate = 0;
                Console.WriteLine("Peças restantes:");
                for(int i = 0; i<8 ;i++){         
                char simbolo = todasPecas[i].GetPeca();
                string icon = char.ToString(simbolo);
                todasPecas[i].GetCor();
                    if(todasPecas[i].GetPosicao()==0){
                        empate +=1;
                        Console.Write((i+1) + "-" + icon+ " ");
                    }   
                }
                Console.WriteLine();
                for(int i = 8; i<16 ;i++){
                char simbolo = todasPecas[i].GetPeca();
                string icon = char.ToString(simbolo);
                todasPecas[i].GetCor();
                    if(todasPecas[i].GetPosicao()==0){
                        empate +=1;
                        Console.Write((i+1) + "-" + icon+ " ");
                    }   
                }
                Console.WriteLine();
                //verificar empate 
                if(VerificarEmpate(empate)){
                    jg = false;
                   Console.Write($"Não existem peças restantes o jogo Empatou");
                   break;
                }
                //verificar quem ganha
                Console.ForegroundColor = ConsoleColor.White;
                if (Fim.VerificarFim(todasPecas)){
                    jg = false;
                   Console.WriteLine($"Player {playeratual} ganhou!!!");
                   break;
                };  
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
                    Console.WriteLine($"Turno do player {playeratual}:");
                    Console.Write($"Player {adversario}, insira a peça");
                    Console.Write(" que vai ser utilizada");
                    Console.Write($" pelo player {playeratual}");
                    Console.Write(" (um número de 1 a 16):\n-->");
                    string aSer = Console.ReadLine();
                    //este metodo try aprendi na escola no 12ºano
                    try{
                        aserusada = int.Parse(aSer)-1;
                        a += 1;
                    } catch{
                        Console.WriteLine("Erro. Insira um número.");
                        a-=1;
                    }
                    if(aserusada < 0 || aserusada >= 16){
                        Console.WriteLine("Erro. Número não está dentro" + 
                        " dos parâmetros.");
                    }else{
                        a += 1;
                        
                    };
                    for(int i = 0; i < pecasusadas.Length; i++){
                        if(pecasusadas[i] == aserusada){
                        Console.WriteLine("Erro. Número já foi utilizado.");
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
                    
                    Console.Write($"Player {playeratual}, insira a posição");
                    Console.Write(" que vai colocar a peça");
                    Console.Write(" (número de 1 a 16 a contar a partir" + 
                    " do canto superior esquerdo para a direita):\n-->");
                    string pos = Console.ReadLine();
                    int posicao;
                    posicao = 0;
                    try{
                        posicao = int.Parse(pos);
                    } catch{
                        Console.WriteLine("Erro. Insira um número.");
                        b-=1;
                    }
                    b+=1;
                    if(posicao <= 0 || posicao >= 17 ){
                        Console.Write("Erro. Número não está dentro");
                        Console.WriteLine("dos parâmetros.");
                    }else{
                        
                    }
                    b+=1;
                    //meter o simbolo na posição certa
                    if(tabuleiro[posicao-1] == "-"){
                        tabuleiro[posicao-1] = todasPecas[aserusada].GetPeca().
                        ToString(); 
                        todasPecas[aserusada].SetPosicao(posicao);
                        
                    }else{
                        Console.Write("Erro. Essa posição já tem uma peça.\n");
                        b-=1;
                    }
                    b+=1;
                }
                //fazer com que mude de ronda e identifcar qual peça foi usada 
                //nesta ronda
                pecasusadas[ronda] = aserusada;
                ronda +=1;
            }
            
        }
        static bool VerificarEmpate(int emp){
            if(emp == 0){
                return true;
            }else{
                return false;
            }
            
        }

    }
}
