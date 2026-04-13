using Microsoft.AspNetCore.Mvc;

namespace SDP_WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class SimpleGetAPIController : Controller
    {
        [HttpGet("SimpleGetMethod")]
        public String Get()
        {
            return $"This is returned b the web API server. Current time is:{DateTime.Now}";
        }
    }
}
