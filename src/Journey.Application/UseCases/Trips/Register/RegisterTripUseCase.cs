using Journey.Communication.Requests;

namespace Journey.Application.UseCases.Trips.Register;

public class RegisterTripUseCase
{
    public void Execute(RequestRegisterTripJson request)
    {
        
    }
    
    //AUXILIAR
    private void Validate(RequestRegisterTripJson request)
    {
        if (string.IsNullOrEmpty(request.Name))
            throw new ArgumentException("Nome não pode ser vazio.");
        
        if(request.StartDate < DateTime.UtcNow)
            throw new ArgumentException("A viagem não pode ser " +
                                        "registrada para uma data passada.");

        if (request.EndDate >= request.StartDate)
            throw new ArgumentException("A viagem deve terminar apos a data de inicio.");
    }
    
}