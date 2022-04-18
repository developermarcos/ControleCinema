using ControleCinema.ConsoleApp.Comparilhado;

namespace ControleCinema.ConsoleApp.ModuloFilme
{
    public enum Genero
    {
        Feminino,
        Masculino
    }
    public class Filme : EntidadeBase
    {
        private string nome;
        private string ducacao;
        private Genero genero;

        public Genero Genero
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

    }
}
