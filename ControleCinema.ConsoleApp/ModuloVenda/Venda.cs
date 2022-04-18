using ControleCinema.ConsoleApp.Comparilhado;
using ControleCinema.ConsoleApp.ModuloSessao;

namespace ControleCinema.ConsoleApp.ModuloVenda
{
    public class Venda : EntidadeBase
    {
        private TipoVenda tipoIngresso;
        private decimal valor;
        private Sessao sessao;

        public TipoVenda TipoVenda
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
