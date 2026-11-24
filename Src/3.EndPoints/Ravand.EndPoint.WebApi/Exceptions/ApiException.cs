using Ravand.Core.Domain.Exceptions;

namespace Ravand.EndPoint.WebApi.Exceptions;

public class ApiException : BaseException
{
    public ApiException(string message) : base(message)
    {
    }

    public ApiException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
