using System;
using System.Reflection.Metadata;  

namespace Jogo
{
    class Fim
    {
        public static bool VerificarFim(CriarPecas[] pecas)
        {
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            for(int a = 0; a < 16; a++)
            {
                p1 = pecas[a].GetPosicao();
                if (p1 == 0)
                    continue;
            for(int b = 0; b < 16; b++)
            {
                if (b == a)
                    continue;
                p2 = pecas[b].GetPosicao();
                if (p2 == 0)
                    continue;
            for(int c = 0; c < 16; c++)
            {
                if (c == a || c == b)
                    continue;
                p3 = pecas[c].GetPosicao();
                if (p3 == 0)
                    continue;
            for(int d = 0; d < 16; d++)
            {
                if (d == a || d == b || d == c)
                    continue;
                p4 = pecas[d].GetPosicao();
                if (p4 == 0)
                    continue;

                if (p1 <= 4 && p2 <= 4 && p3 <= 4 && p4 <= 4)
                    return true;
            }
            }
            }
            }
            return true;
        }

    }
}