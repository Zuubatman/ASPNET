using myFristProject.Models;

namespace myFristProject.Services;
public interface ICEPService
{
    IEnumerable<CEPViewModel> listaTodosOsCEPs();
    CEPViewModel? pesquiseUmCEPEspecifico(string CEP);
    void cadastraCEP(CEPViewModel novoCEP);

    void editaCEP(CEPViewModel novoCep, string id);

    void excluirCEP( string cep );
    
}