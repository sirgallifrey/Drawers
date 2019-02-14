using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Drawers.Domain.Exceptions;
using Drawers.Domain.Infrastructure;

namespace Drawers.Domain.ValueObjects
{
  public class PhoneNumber : ValueObject
  {
    private PhoneNumber()
    {
    }

    public PhoneNumber(string value)
    {
      Value = value;
    }

    public string Value { get; private set; }


    public static implicit operator string(PhoneNumber phoneNumber)
    {
      return phoneNumber.ToString();
    }

    public static explicit operator PhoneNumber(string value)
    {
      return new PhoneNumber(value);
    }

    public override string ToString()
    {
      return Value;
    }

    protected override IEnumerable<object> GetAtomicValues()
    {
      yield return Value;
    }
  }
}