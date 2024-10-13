using System.Net;

namespace Journey.Exception.ExceptionsBase;

public class ErrorOnValidationException : JourneyException
{
    //SOMENTE O CONTRUTOR PODE ALTERAR O VALOR DESSA PROPRIEDADE
    private readonly IList<string> _errors;
    public ErrorOnValidationException(IList<string> messages) : base(String.Empty)
    {
        _errors = messages;
    }

    public override HttpStatusCode GetStatusCode()
    {
        return HttpStatusCode.BadRequest;
    }

    public override IList<string> GetErrorMessages()
    {
        return _errors;
    }
}