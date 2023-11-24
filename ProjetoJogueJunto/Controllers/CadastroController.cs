using Microsoft.AspNetCore.Mvc;
using ProjetoJogueJunto.Models;
using ProjetoJogueJunto.Repositorios;

namespace ProjetoJogueJunto.Controllers
{
    public class CadastroController : Controller
    {
        private readonly ICadastroRepositorio _cadastroRepositorio;
        public CadastroController(ICadastroRepositorio cadastroRepositorio)
        {
            _cadastroRepositorio = cadastroRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(CadastroModel cadastro)
        {
            if (ModelState.IsValid)
            {
                _cadastroRepositorio.Cadastrar(cadastro);
                return RedirectToAction("Index");
            }
            return View("Index", cadastro);
            
        }
    }
}
