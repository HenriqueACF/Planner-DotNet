using System.Net;

namespace Journey.Exception.ExceptionsBase;

public abstract class JourneyException : System.Exception
{
    public JourneyException(string message) : base(message)
    {
        
    }
    //Obriga todas as classes que fazem herança a implementar essa função.
    public abstract HttpStatusCode GetStatusCode();
}