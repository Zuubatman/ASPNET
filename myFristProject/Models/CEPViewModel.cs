using System.ComponentModel.DataAnnotations; 
namespace myFristProject.Models;

public class CEPViewModel {

    //Verificação de variável ( tem q importal o System.ComponentModule.DataAnnotations)
    [StringLength ( maximumLength: 8 , ErrorMessage = "Vou dar um mortal de costa", MinimumLength = 3)]
    public string? CEP{ get; set;}

    public List<string>? ceps {get; set;}

}
