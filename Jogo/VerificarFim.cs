using System;
using System.Reflection.Metadata;  

namespace Jogo
{
    public class Fim
    {
        public static bool VerificarFim(TipoPecas[] lista)
        {
            return PrimeiroCiclo(lista);
        }

        public bool PrimeiroCiclo(TipoPecas[] lista)
        {
            for (int i = 0; i < 16; i++)
            {
                SegundoCiclo();
            }
            return true;
        }
        private bool SegundoCiclo(TipoPecas[] lista)
        {
            for (int i = 0; i < 16; i++)
            {
                TerceiroCiclo();
            }
        }
        private bool TerceiroCiclo(TipoPecas[] lista)
        {
            for (int i = 0; i < 16; i++)
            {
                QuartoCiclo();
            }
        }
        private bool QuartoCiclo(TipoPecas[] lista)
        {
            for (int i = 0; i < 16; i++)
            {

            }
        }
    }
}