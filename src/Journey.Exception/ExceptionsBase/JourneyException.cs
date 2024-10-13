namespace Journey.Exception.ExceptionsBase;

public abstract class JourneyException : System.Exception
{
    public JourneyException(string message) : base(message)
    {
        
    }
}