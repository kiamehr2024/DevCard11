using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return PartialView("Footer");
        }
    }
}
