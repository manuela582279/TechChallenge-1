using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TechChallenge.Models;

namespace TechChallenge.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

public IActionResult About ()
    {

//imagine que os dados abaixo vieram de um bando de dados

//criando var que sera levados para uma page, no caso aqui, minha page About
        ViewData["Nome"] = "Cristiano de Paula";
        ViewData["Idade"] = 45;

        ViewBag.Cidade = "Jau";
        ViewBag.UF = "SP";   //viewbag e viewdata servem pra trasnportar dados do controller para a view, dados= API, db etc - Cris



        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
