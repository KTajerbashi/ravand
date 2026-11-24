using Ravand.Core.Domain.Exceptions;

namespace Ravand.Core.Application.Exceptions;
public class AppException : BaseException
{
    public AppException(string message) : base(message)
    {
    }

    public AppException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
