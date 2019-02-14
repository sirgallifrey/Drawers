using System;
using System.Collections.Generic;
using Drawers.Domain.ValueObjects;

namespace Drawers.Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Cnpj { get; set; }
        //public ICollection<PhoneNumber> PhoneNumbers { get; private set; }

    }
}