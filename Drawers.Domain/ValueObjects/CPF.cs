using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Drawers.Domain.Exceptions;
using Drawers.Domain.Infrastructure;

namespace Drawers.Domain.ValueObjects
{
  public class CPF : ValueObject
  {
    static private readonly Regex PONCTUATION = new Regex(@"[\.-]");
    static private readonly Regex ANY_NON_DIGIT = new Regex(@"\D");
    private CPF()
    {
    }

    public CPF(string value)
    {
      var valueWithoutPonctuation = PONCTUATION.Replace(value, "");
      if (valueWithoutPonctuation.Length != 11 || ContainsAnyNonDigit(valueWithoutPonctuation) ) {
        throw new CPFInvalidFormatException(value);
      }
      Value = valueWithoutPonctuation;
    }

    private bool ContainsAnyNonDigit(string value) {
      var matches = ANY_NON_DIGIT.Matches(value);
      return matches.Count > 0;
    }

    public string Value { get; private set; }


    public static implicit operator string(CPF cpf)
    {
      return cpf.ToString();
    }

    public static explicit operator CPF(string value)
    {
      return new CPF(value);
    }

    public override string ToString()
    {
      return Value;
    }

    protected override IEnumerable<object> GetAtomicValues()
    {
      yield return Value;
    }

    public void Validate() {
      //do validation.
    }
  }
}