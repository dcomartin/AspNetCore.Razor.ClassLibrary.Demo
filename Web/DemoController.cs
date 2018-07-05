using Microsoft.AspNetCore.Mvc;

namespace Web
{
    public class DemoController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View("/MyView.cshtml");
        }
    }
}
