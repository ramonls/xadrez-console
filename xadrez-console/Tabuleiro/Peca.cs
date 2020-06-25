﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = posicao;
            Tabuleiro = tabuleiro;
            Cor = Cor;
            QuantidadeMovimentos = 0;
        }
    }
}
