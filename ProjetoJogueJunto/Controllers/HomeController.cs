using Microsoft.AspNetCore.Mvc;
namespace ProjetoJogueJunto.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
