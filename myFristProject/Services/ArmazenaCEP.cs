using myFristProject.Models;

namespace myFristProject.Services;

public class ArmazenaCEP : ICEPService
{
    private List<CEPViewModel> listaDeCEPs;

    public ArmazenaCEP(){
        listaDeCEPs = new List<CEPViewModel>();
        listaDeCEPs.Add(new CEPViewModel(){CEP="90470320"});
        listaDeCEPs.Add(new CEPViewModel(){CEP="90150040"});
        listaDeCEPs.Add(new CEPViewModel(){CEP="91740000"});
        listaDeCEPs.Add(new CEPViewModel(){CEP="90035005"});
    }
    public void cadastraCEP(CEPViewModel novoCEP)
    {
        listaDeCEPs.Add(novoCEP);
    }

    public void editaCEP(CEPViewModel novoCEP, string id)
    {
        Console.WriteLine(id);
        listaDeCEPs.RemoveAll(cep => cep.CEP == id);
        listaDeCEPs.Add(novoCEP);
    }

    public void excluirCEP(string cep){
        listaDeCEPs.RemoveAll(c => c.CEP == cep);
    }

    public IEnumerable<CEPViewModel> listaTodosOsCEPs()
    {
        return listaDeCEPs;
    }

    public CEPViewModel? pesquiseUmCEPEspecifico(string CEP)
    {
        throw new NotImplementedException();
    }
}