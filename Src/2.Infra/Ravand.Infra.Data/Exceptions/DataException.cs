using Ravand.Core.Domain.Exceptions;

namespace Ravand.Infra.Data.Exceptions;

public class DataException : BaseException
{
    public DataException(string message) : base(message)
    {
    }

    public DataException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
