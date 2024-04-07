using System;

namespace Jogo
{
    /// <summary>
    /// Construtor do tipo peças, para criação de cada peça individual
    /// </summary>
    class CriarPecas
    {
        int posicao;
        char peca;
        TipoPecas tipo;
        
        /// <summary>
        /// Cria o tipo peça, recebendo a posição, o simbolo e a tipo de peça
        /// </summary>
        /// <param name="pos">A posição da peça</param>
        /// <param name="pe">O símbolo da peça</param>
        /// <param name="ti">O tipo da peça</param>
        public CriarPecas(int pos, char pe, TipoPecas ti)
        {
            posicao = pos;
            peca = pe;
            tipo = ti;
        }

        /// <summary>
        /// Mostra a posição de uma peça específica
        /// </summary>
        /// <returns>A posição</returns>
        public int GetPosicao()
        {
            return posicao;
        }

        /// <summary>
        /// Modifica a posição da peça
        /// </summary>
        /// <param name="poss">Recebe a posição a a ser alterada</param>
        public void SetPosicao(int poss)
        {
            posicao = poss;
        }

        /// <summary>
        /// Mostra o tipo de uma peça específica
        /// </summary>
        /// <returns>O tipo</returns>
        public TipoPecas GetTipo()
        {
            return tipo;
        }

        /// <summary>
        /// Mostra o símbolo de uma peça específica
        /// </summary>
        /// <returns>O símbolo</returns>
        public char GetPeca()
        {
            return peca;
        }

        /// <summary>
        /// Torna a consola na cor da peça
        /// </summary>
        public void GetCor()
        {
            if((tipo & TipoPecas.Cor) == TipoPecas.Cor){
                Console.ForegroundColor = ConsoleColor.Red;

            }else{
                Console.ForegroundColor = ConsoleColor.Blue;
            };
        }
    }
}