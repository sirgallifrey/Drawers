using System;
using System.Collections.Generic;
using Drawers.Domain.ValueObjects;

namespace Drawers.Domain.Entities
{
    public class Person
    {
        public Person () {
            PhoneNumbers = new HashSet<PhoneNumber>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Cpf { get; set; }
        public ICollection<PhoneNumber> PhoneNumbers { get; private set; }
    }
}
