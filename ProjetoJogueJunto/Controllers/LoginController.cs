using Microsoft.AspNetCore.Mvc;
using ProjetoJogueJunto.Models;
using ProjetoJogueJunto.Repositorios;

namespace ProjetoJogueJunto.Controllers
{
    public class LoginController : Controller
    {
        private readonly ICadastroRepositorio _cadastroRepositorio;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CadastroModel cadastro = _cadastroRepositorio.BuscarPorLogin(loginModel.Email);
                    if (cadastro != null)
                    {
                        if (cadastro.SenhaValida(loginModel.Senha))
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        
                    }
                    
                }
                return View("Index");
            }
            catch (Exception erro)
            {

                return RedirectToAction("Index");
            }
        }
    }
}
