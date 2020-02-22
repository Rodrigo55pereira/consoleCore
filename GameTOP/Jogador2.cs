using System;
using System.Collections.Generic;
using System.Text;

namespace GameTOP
{
    class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona estas pateando";
        }

        public string Corre()
        {
            return "Maradona estas corriendo";
        }

        public string Passe()
        {
            return "Maradona estas pasando";
        }
    }
}
