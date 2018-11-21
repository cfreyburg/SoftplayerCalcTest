using Microsoft.AspNetCore.Mvc;
using SoftplayerCalcTest.Domain;

namespace SoftplayerCalcTest.Controllers
{
    [Route("api/[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ICalculaJurosService _service;

        public CalculaJurosController(ICalculaJurosService service)
        {
            _service = service;
        }

        [HttpGet, Route("{valorInicial}/{meses}")]
        public decimal Get(decimal valorInicial, int meses)
        {
            return _service.CalculaJuros(valorInicial, meses);
        }
    }
}
