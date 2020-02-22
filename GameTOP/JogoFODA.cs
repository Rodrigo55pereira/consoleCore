using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        public readonly iJogador _jogador1;
        public readonly iJogador _jogador2;
        public readonly iJogador _jogador3;

        public JogoFODA(iJogador jogador1, iJogador jogador2, iJogador jogador3)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
            _jogador3 = jogador3;
        }

        public void IniciarJogo()
        {
            Console.WriteLine(_jogador1.Chuta());
            Console.WriteLine(_jogador1.Corre());
            Console.WriteLine(_jogador1.Passe());

            Console.WriteLine("\nPróximo Jogador\n");

            Console.WriteLine(_jogador2.Chuta());
            Console.WriteLine(_jogador2.Corre());
            Console.WriteLine(_jogador2.Passe());

            Console.WriteLine("\nPróximo Jogador\n");

            Console.WriteLine(_jogador3.Chuta());
            Console.WriteLine(_jogador3.Corre());
            Console.WriteLine(_jogador3.Passe());
        }
    }
}
