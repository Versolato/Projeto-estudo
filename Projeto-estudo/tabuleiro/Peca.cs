﻿namespace tabuleiro {
    class Peca {

        public Posicao posicao { get; set; } 
        public Cor cor { get; protected set; }
        public int ateMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.ateMovimentos = 0;           
        }
    }
}
