using System;

namespace Jogo
{
    /// <summary>
    /// 
    /// </summary>
    class CriarPecas
    {
        int posicao;
        char peca;
        TipoPecas tipo;
        
        public CriarPecas(int pos, char pe, TipoPecas ti)
        {
            posicao = pos;
            peca = pe;
            tipo = ti;
        }

        public int GetPosicao()
        {
            return posicao;
        }

        public TipoPecas GetTipo()
        {
            return tipo;
        }

        public char GetPeca()
        {
            return peca;
        }
        public void GetCor()
        {
            if((tipo & TipoPecas.Cor) == TipoPecas.Cor){
                Console.ForegroundColor = ConsoleColor.Blue;

            }else{
                Console.ForegroundColor = ConsoleColor.Blue;
            };
        }
    }
}