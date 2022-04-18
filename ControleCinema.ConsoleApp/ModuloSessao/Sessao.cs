using ControleCinema.ConsoleApp.Comparilhado;
using ControleCinema.ConsoleApp.ModuloSala;
using ControleCinema.ConsoleApp.ModuloFilme;
using System;

namespace ControleCinema.ConsoleApp.ModuloSessao
{
    public class Sessao : EntidadeBase
    {
        private Sala sala;
        private Filme filme;
        private DateTime data;
        private TimeSpan hora;
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

        public override string Validar()
        {
            throw new System.NotImplementedException();
        }

        public bool SessaoEncerrada()
        {
            return false;
        }
    }
}
