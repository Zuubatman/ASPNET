using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myFristProject.Models;

namespace myFristProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    //https://localhost:7228/Home/index2/batata
    public IActionResult Index2(string id)
    {
        ViewData["nome"] = id;
        ViewBag.Nome = id + "_Pão";
        return View("Index");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Coiso()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
