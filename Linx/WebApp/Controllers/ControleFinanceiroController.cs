using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ControleFinanceiroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
