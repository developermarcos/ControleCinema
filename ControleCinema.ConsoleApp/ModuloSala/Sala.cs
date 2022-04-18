using ControleCinema.ConsoleApp.Comparilhado;
using System.Collections.Generic;

namespace ControleCinema.ConsoleApp.ModuloSala
{
    public class Sala : EntidadeBase
    {
        private string nome;
        private List<Assento> assentos;

        public Assento Assento
        {
            get => default;
            set
            {
            }
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

        public override string Validar()
        {
            throw new System.NotImplementedException();
        }
        public int capacidadeSala()
        {
            return assentos.Count;
        }
    }
}
