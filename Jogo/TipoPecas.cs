using System;

namespace Jogo
{
    [Flags]
    enum TipoPecas
    {
        Tamanho = 1 << 0, //Se 0 ent�o pequeno, se 1 ent�o grande
        Cor = 1 << 1, //Se 0 ent�o branco, se 1 ent�o castanho
        Buraco = 1 << 2, //Se 0 ent�o sem buraco, se 1 ent�o com buraco
        Forma = 1 << 3 //Se 0 ent�o redondo, se 1 ent�o quadrado
    }
}