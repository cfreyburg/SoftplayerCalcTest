using Microsoft.AspNetCore.Mvc;

namespace SoftplayerCalcTest.Controllers
{
    [Route("api/[controller]")]
    public class ShowMeTheCodeController : ControllerBase
    {
        const string URL = "https://github.com/cfreyburg/SoftplayerCalcTest";

        [HttpGet]
        public string Get()
        {
            return URL;
        }
    }
}