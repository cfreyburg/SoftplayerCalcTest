using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoftplayerCalcTest.Domain;
using SoftplayerCalcTest.Services;

namespace SoftplayerCalcTest.Tests.Services
{
    [TestClass]
    public class CalculaJurosServiceTest
    {
        private readonly Mock<ICalculaJurosHelper> _helper;
        private readonly ICalculaJurosService _service;

        public CalculaJurosServiceTest()
        {
            _helper = new Mock<ICalculaJurosHelper>();
            _service = new CalculaJurosService(_helper.Object);
        }

        [TestMethod]
        public void service_deve_retornar_valor_calculado()
        {
            decimal valorInicial = 100;
            int meses = 5;
            decimal taxa = 1.0510100M;
            decimal expected = 105.10M;

            _helper.Setup(q => q.ObterTaxa(meses)).Returns(taxa);
            _helper.Setup(q => q.Truncar(valorInicial * taxa)).Returns(expected);

            var actual = _service.CalculaJuros(valorInicial, meses);

            Assert.AreEqual(expected, actual);
        }
    }
}
