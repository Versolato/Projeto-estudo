using System;
using tabuleiro;
using xadrez;
using System.Globalization;

namespace Projeto_estudo {
    class Program {
        static void Main(string[] args) {

            try {
               Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(3, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 0));

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 4));

                Tela.imprimirTabuleiro(tab);

           }

            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }
}
