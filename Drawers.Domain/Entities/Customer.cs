using System;
using System.Collections.Generic;

namespace Drawers.Domain.Entities
{
  public class Customer
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public Company Company { get; set; }
    public Person Person { get; set; }
  }
}
