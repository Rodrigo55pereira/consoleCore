using System;
using System.Collections.Generic;
using System.Text;

namespace GameTOP
{
    class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome)
        {
            _Nome = nome;
        }

        //Chuta
        public string Chuta()
        {
            return ($"{_Nome} está Chutando");
        }

        //Corre
        public  string Corre()
        {
            return ($"{_Nome} está Correndo");
        }

        // Passe
        public string Passe()
        {
            return ($"{_Nome} está Passando");
        }
    }
}
