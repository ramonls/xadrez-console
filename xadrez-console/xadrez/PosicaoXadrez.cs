using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
/*
 * Classe para auxiliar a pensar no contexdo do zadrez, visto que na programação a matriz começa em 0,0 e assim por diante
 * ...
 * 4- - - -
 * 3- - - -
 * 2- - - -
 * 1- - - - 
 *  A B C D...
 *
 * No caso é de (1 ao 8) e do (A ao H)
 */
namespace xadrez_console.xadrez
{
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            //"" as aspas duplas é para forçar imprimir em string
            return ""+Coluna+Linha;
        }
    }
}
