using System.ComponentModel;

namespace Ravand.EndPoint.WebApi.Models;

public enum TokenType : byte
{
    [Description("")]
    JWT = 1,
    [Description("")]
    JWE = 2,
}
