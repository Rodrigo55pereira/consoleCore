using System;
using GameTOP.Lib;
using GameTOP.Interface;

namespace GameTOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador1("Ronaldo"), new Jogador2());
            
            jogo.IniciarJogo();
        }
    }
}
