using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoftplayerCalcTest.Controllers;
using SoftplayerCalcTest.Domain;

namespace SoftplayerCalcTest.Tests.Controllers
{
    [TestClass]
    public class CalculaJurosControllerTest
    {
        private readonly Mock<ICalculaJurosService> _service;
        private readonly CalculaJurosController _controller;
        public CalculaJurosControllerTest()
        {
            _service = new Mock<ICalculaJurosService>();
            _controller = new CalculaJurosController(_service.Object);
        }

        [TestMethod]
        public void controller_deve_retornar_juros()
        {
            decimal valorInicial = 100;
            int meses = 5;
            decimal expected = 105.10M;

            _service.Setup(q => q.CalculaJuros(valorInicial, meses)).Returns(expected);

            var actual = _controller.Get(valorInicial, meses);

            Assert.AreEqual(expected, actual);
        }
    }
}
