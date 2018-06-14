
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    public class CorsController: Controller
    {
        public IActionResult Index()
        {
            Response.Headers.Add("Access-Control-Allow-Origin", Request.Headers["Origin"]);

            return base.Json(true);
        }
    }
}