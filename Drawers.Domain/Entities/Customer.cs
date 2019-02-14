using System;
using System.Collections.Generic;

namespace Drawers.Domain.Entities
{
  public class Customer
  {
    public Customer()
    {
        //People = new HashSet<Person>();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public Company Company { get; set; }
    //public ICollection<Person> People { get; private set; }
  }
}