using Microsoft.AspNetCore.Mvc;

namespace ProjetoJogueJunto.Controllers
{
    public class EscolhaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CriarVolei()
        {
            return View();
        }
        public IActionResult CriarTenis()
        {
            return View();
        }
    }
}
