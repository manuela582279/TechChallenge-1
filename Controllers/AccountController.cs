using Microsoft.AspNetCore.Mvc;
using TechChallenge.Models;

namespace TechChallenge.Controllers;

public class AccountController : Controller
{

    // =====================================
    // GET: /Account/Register
    // Exibe formulário de cadastro
    // =====================================
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    // =====================================
    // POST: /Account/Register
    // Processa cadastro do usuário
    // =====================================
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(
        RegisterViewModel model)
    {
        return View();
    }

    // =====================================
    // GET: /Account/Login
    // Exibe formulário de login
    // =====================================
    [HttpGet]
    public IActionResult Login(
        string? returnUrl = null)
    {
        return View();
    }



    // =====================================
    // POST: /Account/Login
    // Realiza autenticação
    // =====================================
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(
        LoginViewModel model)
    {
        return View();
    }



    // =====================================
    // POST: /Account/Logout
    // Encerra sessão do usuário
    // =====================================
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        return RedirectToAction(
            "Index",
            "Home"
        );
    }



    // =====================================
    // GET: /Account/AccessDenied
    // Página sem permissão
    // =====================================
    [HttpGet]
    public IActionResult AccessDenied()
    {
        return View();
    }

}