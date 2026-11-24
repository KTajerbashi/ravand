using Ravand.Core.Domain.Exceptions;

namespace Ravand.EndPoint.WebApp.Exceptions;

public class WebAppException : BaseException
{
    public WebAppException(string message) : base(message)
    {
    }

    public WebAppException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
