using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftplayerCalcTest.Domain;
using SoftplayerCalcTest.Services;

namespace SoftplayerCalcTest.Tests.Services
{
    [TestClass]
    public class CalculaJurosHelperTest
    {
        private readonly ICalculaJurosHelper _helper;

        public CalculaJurosHelperTest()
        {
            _helper = new CalculaJurosHelper();        
        }

        [TestMethod]
        public void helper_deve_retornar_taxa()
        {
            int meses = 5;
            decimal expected = 1.0510100501M;

            var actual =_helper.ObterTaxa(meses);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void helper_deve_truncar()
        {
            decimal valor = 1.0510100501M;
            decimal expected = 1.05M;

            var actual = _helper.Truncar(valor);

            Assert.AreEqual(expected, actual);
        }
    }
}
