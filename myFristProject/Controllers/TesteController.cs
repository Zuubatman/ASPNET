using Microsoft.AspNetCore.Mvc;

public class TesteController : Controller
{

    public List<string> nomes;

    public TesteController () {
        this.nomes = new List<string>();
        nomes.Add("Jose");
        nomes.Add("Joao");
        nomes.Add("Lavínia");
    }

    public void Metodo01(){
        Response.WriteAsync("<p>oiiii</p>");
    }

    public string Metodo02() => "Loucura q ela fez comigo";

    //https://localhost:7228/Teste/Metodo03?nome=Vanderley
    public void Metodo03( string nome){
        Console.WriteLine($"Olá {nome}");
    }

    [Route("/Metodo07/{nome}")]
    //https://localhost:7228/Metodo07/Paulo
    public void Metodo07( string nome){
        Console.WriteLine($"Olá {nome}");
    }

    public void Metodo04( string id){
        Console.WriteLine($"Olá {id}");
    }

    public void Metodo05( int id){
        Console.WriteLine(id*2);
    }

    //https://localhost:7228/Teste/Metodo06?nome=Paulo&idade=45
    public void Metodo06( string nome , int idade){
        Console.WriteLine($"Olá {nome} você tem {idade} anos.");
    }

    public void Metodo09( string nome , int idade){
        Console.WriteLine($"Olá {nome} você tem {idade} anos.");
    }

    public List<string> Metodo08() => nomes;

    //Só aceita operação de Post
    [HttpPost]
    public string Metod10(){
        return "operação tipo post";
    }

    //Só aceita operação de Get 
    [HttpGet]
    public string Metod11(){
        return "operação tipo get";
    }

    public void Index(){
        Console.WriteLine("Opaaaa");
    }

}
