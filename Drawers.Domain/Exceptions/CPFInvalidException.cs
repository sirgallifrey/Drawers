using System;

namespace Drawers.Domain.Exceptions
{
  public class CPFInvalidException : Exception
  {
    public CPFInvalidException(string cpf, Exception ex)
        : base($"CPF \"{cpf}\" is invalid.", ex)
    {
    }
  }
}
