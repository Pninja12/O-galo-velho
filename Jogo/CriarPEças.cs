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
        public int GetCor()
        {
            if((tipo & TipoPecas.Cor) == TipoPecas.Cor){
                return 1;

            }else{
                return 0;
            };
        }
    }
}