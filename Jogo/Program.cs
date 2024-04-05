using System;

namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            // Obtidos pela a ajuda do Copilot
            char openBox = '\u25A1'; // Open box
            char closedBox = '\u25AA'; // Closed box
            char largerOpenBox = '\u2610'; // Larger open box
            char largerClosedBox = '\u25A0'; // Larger closed box
            char openCircle = '\u25CB'; // Open circle
            char closedCircle = '\u25CF'; // Closed circle
            char largerOpenCircle = '\u25EF'; // Larger open circle
            char largerClosedCircle = '\u2B24'; // Larger closed circle
            
            //Console.ForegroundColor = ConsoleColor.Brown;
            //Console.ForegroundColor = ConsoleColor.White;

            CriarPecas[] pecas = new CriarPecas [16];
            pecas[0] = new CriarPecas(0,'a',
            TipoPecas.Cor|TipoPecas.Tamanho|TipoPecas.Buraco|TipoPecas.Forma);
            pecas[1] = new CriarPecas(0,'a',
            TipoPecas.Cor|TipoPecas.Buraco|TipoPecas.Forma);
            pecas[2] = new CriarPecas(0,'a',
            TipoPecas.Cor|TipoPecas.Tamanho|TipoPecas.Buraco);
            pecas[3] = new CriarPecas(0,'a',
            TipoPecas.Cor|TipoPecas.Buraco);
            pecas[4] = new CriarPecas(0,'a',
            TipoPecas.Cor|TipoPecas.Tamanho|TipoPecas.Forma);
            pecas[5] = new CriarPecas(0,'a',
            TipoPecas.Cor|TipoPecas.Forma);
            pecas[6] = new CriarPecas(0,'a',
            TipoPecas.Cor|TipoPecas.Tamanho);
            pecas[7] = new CriarPecas(0,'a',
            TipoPecas.Cor);
            pecas[8] = new CriarPecas(0,'a',
            TipoPecas.Tamanho|TipoPecas.Buraco|TipoPecas.Forma);
            pecas[9] = new CriarPecas(0,'a',
            TipoPecas.Buraco|TipoPecas.Forma);
            pecas[10] = new CriarPecas(0,'a',
            TipoPecas.Tamanho|TipoPecas.Buraco);
            pecas[11] = new CriarPecas(0,'a',
            TipoPecas.Buraco);
            pecas[12] = new CriarPecas(0,'a',
            TipoPecas.Tamanho|TipoPecas.Forma);
            pecas[13] = new CriarPecas(0,'a',
            TipoPecas.Forma);
            pecas[14] = new CriarPecas(0,'a',
            TipoPecas.Tamanho);
            pecas[15] = new CriarPecas(0,'a',0);
        }
    }
}
