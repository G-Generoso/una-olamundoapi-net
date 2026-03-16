
using Microsoft.AspNetCore.Mvc;

namespace OlaMundoApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class OlaMundoController : ControllerBase
    {
        public string Get()
        {
            return "Olá, mundo!!";
        }
    }
}