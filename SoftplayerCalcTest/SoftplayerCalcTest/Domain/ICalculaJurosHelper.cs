namespace SoftplayerCalcTest.Domain
{
    public interface ICalculaJurosHelper
    {
        decimal ObterTaxa(int meses);
        decimal Truncar(decimal valor);
    }
}
