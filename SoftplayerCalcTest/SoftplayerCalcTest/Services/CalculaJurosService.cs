using SoftplayerCalcTest.Domain;

namespace SoftplayerCalcTest.Services
{
    public class CalculaJurosService : ICalculaJurosService
    {
        private readonly ICalculaJurosHelper _helper;
        public CalculaJurosService(ICalculaJurosHelper helper)
        {
            _helper = helper;
        }

        public decimal CalculaJuros(decimal valorInicial, int meses)
        {
            var taxa = _helper.ObterTaxa(meses);
            var valor = valorInicial * taxa;

            return _helper.Truncar(valor);
        }
    }
}
