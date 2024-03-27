using System;

namespace Jogo
{
    /// <summary>
    /// 
    /// </summary>
    [Flags]
    enum TipoPeças
    {
        Tamanho = 1 << 0, //Se 0 então pequeno, se 1 então grande
        Cor = 1 << 1, //Se 0 então branco, se 1 então preto
        Buraco = 1 << 2, //Se 0 então sem buraco, se 1 então com buraco
        Forma = 1 << 3 //Se 0 então redondo, se 1 então quadrado
    }
}