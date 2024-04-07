using System;

namespace Jogo
{
    /// <summary>
    /// Enumerador para identificar cada peça (tipo da peça)
    /// </summary>
    [Flags]
    enum TipoPecas
    {
        Tamanho = 1 << 0, //Se 0 então pequeno, se 1 então grande
        Cor = 1 << 1, //Se 0 então branco, se 1 então castanho
        Buraco = 1 << 2, //Se 0 então sem buraco, se 1 então com buraco
        Forma = 1 << 3 //Se 0 então redondo, se 1 então quadrado
    }
}