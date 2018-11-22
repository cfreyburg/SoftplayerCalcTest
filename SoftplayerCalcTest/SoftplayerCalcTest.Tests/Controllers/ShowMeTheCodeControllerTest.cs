using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftplayerCalcTest.Controllers;

namespace SoftplayerCalcTest.Tests.Controllers
{
    [TestClass]
    public class ShowMeTheCodeControllerTest
    {
        private readonly ShowMeTheCodeController _controller;

        public ShowMeTheCodeControllerTest()
        {
            _controller = new ShowMeTheCodeController();
        }

        [TestMethod]
        public void controller_deve_retornar_url()
        {
            var expected = "https://github.com/cfreyburg/SoftplayerCalcTest";
            var actual = _controller.Get();

            Assert.AreEqual(expected, actual);
        }
    }
}
