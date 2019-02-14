using System;

namespace Drawers.Domain.Exceptions
{
  public class CPFInvalidFormatException : Exception
  {
    public CPFInvalidFormatException(string cpf)
        : base($"The value \"{cpf}\" does not look like a CPF.")
    {
    }
  }
}
