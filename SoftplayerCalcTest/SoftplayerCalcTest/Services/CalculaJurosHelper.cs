using SoftplayerCalcTest.Domain;
using System;

namespace SoftplayerCalcTest.Services
{
    public class CalculaJurosHelper : ICalculaJurosHelper
    {
        const double JURO = 1.01;

        public decimal ObterTaxa(int meses)
        {
            return Convert.ToDecimal(Math.Pow(JURO, meses));
        }

        public decimal Truncar(decimal valor)
        {
            return Math.Round(valor, 2);
        }
    }
}
