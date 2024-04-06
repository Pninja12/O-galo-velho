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
                t2 = pecas[a].GetTipo();
                if (p2 == 0)
                    continue;
            for(int c = 0; c < 16; c++)
            {
                if (c == a || c == b)
                    continue;
                p3 = pecas[c].GetPosicao();
                t3 = pecas[a].GetTipo();
                if (p3 == 0)
                    continue;
            for(int d = 0; d < 16; d++)
            {
                if (d == a || d == b || d == c)
                    continue;
                p4 = pecas[d].GetPosicao();
                t4 = pecas[a].GetTipo();
                if (p4 == 0)
                    continue;

                if (p1 <= 4 && p2 <= 4 && p3 <= 4 && p4 <= 4)
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
                if ((p1>4&&p1<9)&&(p2>4&&p2<9)&&(p3>4&&p3<9)&&(p4>4&&p4<9))
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
                if ((p1>8&&p1<13)&&(p2>8&&p2<13)&&(p3>8&&p3<13)&&(p4>8&&p4<13))
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
                if (p1>12&&p2>12&&p3>12&&p4>12)
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
            return false;
        }

    }
}