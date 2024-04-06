using System;
using System.Reflection.Metadata;  

namespace Jogo
{
    class Fim
    {
        public static bool VerificarFim(CriarPecas[] pecas)
        {
            int p1 = 0;
            TipoPecas t1;
            int p2 = 0;
            TipoPecas t2;
            int p3 = 0;
            TipoPecas t3;
            int p4 = 0;
            TipoPecas t4;
            for(int a = 0; a < 16; a++)
            {
                p1 = pecas[a].GetPosicao();
                t1 = pecas[a].GetTipo();
                if (p1 == 0)
                    continue;
            for(int b = 0; b < 16; b++)
            {
                if (b == a)
                    continue;
                p2 = pecas[b].GetPosicao();
                t2 =  pecas[b].GetTipo();
                if (p2 == 0)
                    continue;
            for(int c = 0; c < 16; c++)
            {
                if (c == a || c == b)
                    continue;
                p3 = pecas[c].GetPosicao();
                t3 = pecas[c].GetTipo();
                if (p3 == 0)
                    continue;
            for(int d = 0; d < 16; d++)
            {
                if (d == a || d == b || d == c)
                    continue;
                p4 = pecas[d].GetPosicao();
                t4 = pecas[d].GetTipo();
                if (p4 == 0)
                    continue;

                if (p1 <= 4 && p2 <= 4 && p3 <= 4 && p4 <= 4){
                    if((t1 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho)&&
                    (t2 & TipoPecas.Tamanho) == (t3 & TipoPecas.Tamanho)&&
                    (t1 & TipoPecas.Tamanho) == (t4 & TipoPecas.Tamanho)&&
                    (t3 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho))
                        return true;
                    if((t1 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco)&&
                    (t2 & TipoPecas.Buraco) == (t3 & TipoPecas.Buraco)&&
                    (t1 & TipoPecas.Buraco) == (t4 & TipoPecas.Buraco)&&
                    (t3 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco))
                        return true;
                    if((t1 & TipoPecas.Forma) == (t2 & TipoPecas.Forma)&&
                    (t2 & TipoPecas.Forma) == (t3 & TipoPecas.Forma)&&
                    (t1 & TipoPecas.Forma) == (t4 & TipoPecas.Forma)&&
                    (t3 & TipoPecas.Forma) == (t2 & TipoPecas.Forma))
                        return true;
                    if((t1 & TipoPecas.Cor) == (t2 & TipoPecas.Cor)&&
                    (t2 & TipoPecas.Cor) == (t3 & TipoPecas.Cor)&&
                    (t1 & TipoPecas.Cor) == (t4 & TipoPecas.Cor)&&
                    (t3 & TipoPecas.Cor) == (t2 & TipoPecas.Cor))
                        return true;
                }
                if ((p1>4&&p1<9)&&(p2>4&&p2<9)&&(p3>4&&p3<9)&&(p4>4&&p4<9)){
                    if((t1 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho)&&
                    (t2 & TipoPecas.Tamanho) == (t3 & TipoPecas.Tamanho)&&
                    (t1 & TipoPecas.Tamanho) == (t4 & TipoPecas.Tamanho)&&
                    (t3 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho))
                        return true;
                    if((t1 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco)&&
                    (t2 & TipoPecas.Buraco) == (t3 & TipoPecas.Buraco)&&
                    (t1 & TipoPecas.Buraco) == (t4 & TipoPecas.Buraco)&&
                    (t3 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco))
                        return true;
                    if((t1 & TipoPecas.Forma) == (t2 & TipoPecas.Forma)&&
                    (t2 & TipoPecas.Forma) == (t3 & TipoPecas.Forma)&&
                    (t1 & TipoPecas.Forma) == (t4 & TipoPecas.Forma)&&
                    (t3 & TipoPecas.Forma) == (t2 & TipoPecas.Forma))
                        return true;
                    if((t1 & TipoPecas.Cor) == (t2 & TipoPecas.Cor)&&
                    (t2 & TipoPecas.Cor) == (t3 & TipoPecas.Cor)&&
                    (t1 & TipoPecas.Cor) == (t4 & TipoPecas.Cor)&&
                    (t3 & TipoPecas.Cor) == (t2 & TipoPecas.Cor))
                        return true;
                }
                if ((p1>8&&p1<13)&&(p2>8&&p2<13)&&(p3>8&&p3<13)&&(p4>8&&p4<13))
                {
                    if((t1 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho)&&
                    (t2 & TipoPecas.Tamanho) == (t3 & TipoPecas.Tamanho)&&
                    (t1 & TipoPecas.Tamanho) == (t4 & TipoPecas.Tamanho)&&
                    (t3 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho))
                        return true;
                    if((t1 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco)&&
                    (t2 & TipoPecas.Buraco) == (t3 & TipoPecas.Buraco)&&
                    (t1 & TipoPecas.Buraco) == (t4 & TipoPecas.Buraco)&&
                    (t3 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco))
                        return true;
                    if((t1 & TipoPecas.Forma) == (t2 & TipoPecas.Forma)&&
                    (t2 & TipoPecas.Forma) == (t3 & TipoPecas.Forma)&&
                    (t1 & TipoPecas.Forma) == (t4 & TipoPecas.Forma)&&
                    (t3 & TipoPecas.Forma) == (t2 & TipoPecas.Forma))
                        return true;
                    if((t1 & TipoPecas.Cor) == (t2 & TipoPecas.Cor)&&
                    (t2 & TipoPecas.Cor) == (t3 & TipoPecas.Cor)&&
                    (t1 & TipoPecas.Cor) == (t4 & TipoPecas.Cor)&&
                    (t3 & TipoPecas.Cor) == (t2 & TipoPecas.Cor))
                        return true;
                }
                if (p1>12&&p2>12&&p3>12&&p4>12){
                    if((t1 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho)&&
                    (t2 & TipoPecas.Tamanho) == (t3 & TipoPecas.Tamanho)&&
                    (t1 & TipoPecas.Tamanho) == (t4 & TipoPecas.Tamanho)&&
                    (t3 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho))
                        return true;
                    if((t1 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco)&&
                    (t2 & TipoPecas.Buraco) == (t3 & TipoPecas.Buraco)&&
                    (t1 & TipoPecas.Buraco) == (t4 & TipoPecas.Buraco)&&
                    (t3 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco))
                        return true;
                    if((t1 & TipoPecas.Forma) == (t2 & TipoPecas.Forma)&&
                    (t2 & TipoPecas.Forma) == (t3 & TipoPecas.Forma)&&
                    (t1 & TipoPecas.Forma) == (t4 & TipoPecas.Forma)&&
                    (t3 & TipoPecas.Forma) == (t2 & TipoPecas.Forma))
                        return true;
                    if((t1 & TipoPecas.Cor) == (t2 & TipoPecas.Cor)&&
                    (t2 & TipoPecas.Cor) == (t3 & TipoPecas.Cor)&&
                    (t1 & TipoPecas.Cor) == (t4 & TipoPecas.Cor)&&
                    (t3 & TipoPecas.Cor) == (t2 & TipoPecas.Cor))
                        return true;
                }
                    
                if ((p1==1||p1==6||p1==11||p1==16)&&
                    (p2==1||p2==6||p2==11||p2==16)&&
                    (p3==1||p3==6||p3==11||p3==16)&&
                    (p4==1||p4==6||p4==11||p4==16)){
                    if((t1 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho)&&
                    (t2 & TipoPecas.Tamanho) == (t3 & TipoPecas.Tamanho)&&
                    (t1 & TipoPecas.Tamanho) == (t4 & TipoPecas.Tamanho)&&
                    (t3 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho))
                        return true;
                    if((t1 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco)&&
                    (t2 & TipoPecas.Buraco) == (t3 & TipoPecas.Buraco)&&
                    (t1 & TipoPecas.Buraco) == (t4 & TipoPecas.Buraco)&&
                    (t3 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco))
                        return true;
                    if((t1 & TipoPecas.Forma) == (t2 & TipoPecas.Forma)&&
                    (t2 & TipoPecas.Forma) == (t3 & TipoPecas.Forma)&&
                    (t1 & TipoPecas.Forma) == (t4 & TipoPecas.Forma)&&
                    (t3 & TipoPecas.Forma) == (t2 & TipoPecas.Forma))
                        return true;
                    if((t1 & TipoPecas.Cor) == (t2 & TipoPecas.Cor)&&
                    (t2 & TipoPecas.Cor) == (t3 & TipoPecas.Cor)&&
                    (t1 & TipoPecas.Cor) == (t4 & TipoPecas.Cor)&&
                    (t3 & TipoPecas.Cor) == (t2 & TipoPecas.Cor))
                        return true;
                    }
                    
                if ((p1==4||p1==7||p1==10||p1==13)&&
                    (p2==4||p2==7||p2==10||p2==13)&&
                    (p3==4||p3==7||p3==10||p3==13)&&
                    (p4==4||p4==7||p4==10||p4==13)){

                    if((t1 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho)&&
                    (t2 & TipoPecas.Tamanho) == (t3 & TipoPecas.Tamanho)&&
                    (t1 & TipoPecas.Tamanho) == (t4 & TipoPecas.Tamanho)&&
                    (t3 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho))
                        return true;
                    if((t1 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco)&&
                    (t2 & TipoPecas.Buraco) == (t3 & TipoPecas.Buraco)&&
                    (t1 & TipoPecas.Buraco) == (t4 & TipoPecas.Buraco)&&
                    (t3 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco))
                        return true;
                    if((t1 & TipoPecas.Forma) == (t2 & TipoPecas.Forma)&&
                    (t2 & TipoPecas.Forma) == (t3 & TipoPecas.Forma)&&
                    (t1 & TipoPecas.Forma) == (t4 & TipoPecas.Forma)&&
                    (t3 & TipoPecas.Forma) == (t2 & TipoPecas.Forma))
                        return true;
                    if((t1 & TipoPecas.Cor) == (t2 & TipoPecas.Cor)&&
                    (t2 & TipoPecas.Cor) == (t3 & TipoPecas.Cor)&&
                    (t1 & TipoPecas.Cor) == (t4 & TipoPecas.Cor)&&
                    (t3 & TipoPecas.Cor) == (t2 & TipoPecas.Cor))
                        return true;
                    }
                    
                if ((p1==1||p1==5||p1==9||p1==13)&&
                    (p2==1||p2==5||p2==9||p2==13)&&
                    (p3==1||p3==5||p3==9||p3==13)&&
                    (p4==1||p4==5||p4==9||p4==13)){
                    if((t1 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho)&&
                    (t2 & TipoPecas.Tamanho) == (t3 & TipoPecas.Tamanho)&&
                    (t1 & TipoPecas.Tamanho) == (t4 & TipoPecas.Tamanho)&&
                    (t3 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho))
                        return true;
                    if((t1 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco)&&
                    (t2 & TipoPecas.Buraco) == (t3 & TipoPecas.Buraco)&&
                    (t1 & TipoPecas.Buraco) == (t4 & TipoPecas.Buraco)&&
                    (t3 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco))
                        return true;
                    if((t1 & TipoPecas.Forma) == (t2 & TipoPecas.Forma)&&
                    (t2 & TipoPecas.Forma) == (t3 & TipoPecas.Forma)&&
                    (t1 & TipoPecas.Forma) == (t4 & TipoPecas.Forma)&&
                    (t3 & TipoPecas.Forma) == (t2 & TipoPecas.Forma))
                        return true;
                    if((t1 & TipoPecas.Cor) == (t2 & TipoPecas.Cor)&&
                    (t2 & TipoPecas.Cor) == (t3 & TipoPecas.Cor)&&
                    (t1 & TipoPecas.Cor) == (t4 & TipoPecas.Cor)&&
                    (t3 & TipoPecas.Cor) == (t2 & TipoPecas.Cor))
                        return true;
                    }
                    
                if ((p1==2||p1==6||p1==10||p1==14)&&
                    (p2==2||p2==6||p2==10||p2==14)&&
                    (p3==2||p3==6||p3==10||p3==14)&&
                    (p4==2||p4==6||p4==10||p4==14)){
                    if((t1 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho)&&
                    (t2 & TipoPecas.Tamanho) == (t3 & TipoPecas.Tamanho)&&
                    (t1 & TipoPecas.Tamanho) == (t4 & TipoPecas.Tamanho)&&
                    (t3 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho))
                        return true;
                    if((t1 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco)&&
                    (t2 & TipoPecas.Buraco) == (t3 & TipoPecas.Buraco)&&
                    (t1 & TipoPecas.Buraco) == (t4 & TipoPecas.Buraco)&&
                    (t3 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco))
                        return true;
                    if((t1 & TipoPecas.Forma) == (t2 & TipoPecas.Forma)&&
                    (t2 & TipoPecas.Forma) == (t3 & TipoPecas.Forma)&&
                    (t1 & TipoPecas.Forma) == (t4 & TipoPecas.Forma)&&
                    (t3 & TipoPecas.Forma) == (t2 & TipoPecas.Forma))
                        return true;
                    if((t1 & TipoPecas.Cor) == (t2 & TipoPecas.Cor)&&
                    (t2 & TipoPecas.Cor) == (t3 & TipoPecas.Cor)&&
                    (t1 & TipoPecas.Cor) == (t4 & TipoPecas.Cor)&&
                    (t3 & TipoPecas.Cor) == (t2 & TipoPecas.Cor))
                        return true;
                    }

                if ((p1==3||p1==7||p1==11||p1==15)&&
                    (p2==3||p2==7||p2==11||p2==15)&&
                    (p3==3||p3==7||p3==11||p3==15)&&
                    (p4==3||p4==7||p4==11||p4==15)){
                    if((t1 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho)&&
                    (t2 & TipoPecas.Tamanho) == (t3 & TipoPecas.Tamanho)&&
                    (t1 & TipoPecas.Tamanho) == (t4 & TipoPecas.Tamanho)&&
                    (t3 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho))
                        return true;
                    if((t1 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco)&&
                    (t2 & TipoPecas.Buraco) == (t3 & TipoPecas.Buraco)&&
                    (t1 & TipoPecas.Buraco) == (t4 & TipoPecas.Buraco)&&
                    (t3 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco))
                        return true;
                    if((t1 & TipoPecas.Forma) == (t2 & TipoPecas.Forma)&&
                    (t2 & TipoPecas.Forma) == (t3 & TipoPecas.Forma)&&
                    (t1 & TipoPecas.Forma) == (t4 & TipoPecas.Forma)&&
                    (t3 & TipoPecas.Forma) == (t2 & TipoPecas.Forma))
                        return true;
                    if((t1 & TipoPecas.Cor) == (t2 & TipoPecas.Cor)&&
                    (t2 & TipoPecas.Cor) == (t3 & TipoPecas.Cor)&&
                    (t1 & TipoPecas.Cor) == (t4 & TipoPecas.Cor)&&
                    (t3 & TipoPecas.Cor) == (t2 & TipoPecas.Cor))
                        return true;
                    }

                if ((p1==4||p1==8||p1==12||p1==16)&&
                    (p2==4||p2==8||p2==12||p2==16)&&
                    (p3==4||p3==8||p3==12||p3==16)&&
                    (p4==4||p4==8||p4==12||p4==16)){
                    if((t1 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho)&&
                    (t2 & TipoPecas.Tamanho) == (t3 & TipoPecas.Tamanho)&&
                    (t1 & TipoPecas.Tamanho) == (t4 & TipoPecas.Tamanho)&&
                    (t3 & TipoPecas.Tamanho) == (t2 & TipoPecas.Tamanho))
                        return true;
                    if((t1 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco)&&
                    (t2 & TipoPecas.Buraco) == (t3 & TipoPecas.Buraco)&&
                    (t1 & TipoPecas.Buraco) == (t4 & TipoPecas.Buraco)&&
                    (t3 & TipoPecas.Buraco) == (t2 & TipoPecas.Buraco))
                        return true;
                    if((t1 & TipoPecas.Forma) == (t2 & TipoPecas.Forma)&&
                    (t2 & TipoPecas.Forma) == (t3 & TipoPecas.Forma)&&
                    (t1 & TipoPecas.Forma) == (t4 & TipoPecas.Forma)&&
                    (t3 & TipoPecas.Forma) == (t2 & TipoPecas.Forma))
                        return true;
                    if((t1 & TipoPecas.Cor) == (t2 & TipoPecas.Cor)&&
                    (t2 & TipoPecas.Cor) == (t3 & TipoPecas.Cor)&&
                    (t1 & TipoPecas.Cor) == (t4 & TipoPecas.Cor)&&
                    (t3 & TipoPecas.Cor) == (t2 & TipoPecas.Cor))
                        return true;
                    }

                
            }
            }
            }
            }
            return false;
        }

    }
}