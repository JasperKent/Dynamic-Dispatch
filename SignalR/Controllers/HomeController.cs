using Microsoft.AspNetCore.Mvc;

namespace SignalR.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Rock Paper Scissors";

            return View();
        }
    }
}