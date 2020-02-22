using GameTOP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Teste Chuta";
        }

        public string Corre()
        {
            return "Teste Corre";
        }

        public string Passe()
        {
            return "Teste Passe";
        }
    }
}
