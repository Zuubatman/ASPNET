using Microsoft.AspNetCore.Mvc;
using myFristProject.Models;
using myFristProject.Services;

namespace myFristProject.Controllers;

public class CEPController : Controller
{
    private ICEPService ac;

    public CEPController(ICEPService ics){
        ac=ics;
    }

    public IActionResult Index()
    {
        ViewData["Nome"] = "José da Silva Luis";
        return View( new CEPViewModel {CEP = "12345678"});
    }
    public IActionResult Cadastra(){
        return View();
    }

    public IActionResult CEPList(){
        return View(ac.listaTodosOsCEPs());
    }

    [HttpGet]
    public IActionResult EditarCEP(string antigoCep){
        Console.WriteLine(antigoCep);
        ViewData["antigoCep"] = antigoCep;
        return View();
    }

    [HttpPost]
    public IActionResult EditarCEP(string antigoCep, CEPViewModel novoCep){
        if(ModelState.IsValid)
            ac.editaCEP( novoCep, antigoCep );
        return View("CEPList", ac.listaTodosOsCEPs());
    }

    [HttpPost]
    public IActionResult Cadastra(CEPViewModel novoCep){
        if(ModelState.IsValid)
            ac.cadastraCEP(novoCep);
        return View("CEPList", ac.listaTodosOsCEPs());
    }
    
    public IActionResult ExcluirCEP(string cep){
        ac.excluirCEP( cep );
        return View("CEPList", ac.listaTodosOsCEPs());
    }
}
