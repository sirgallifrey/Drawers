namespace Drawers.Domain.Entities
{
    public class PersonPhoneNumber
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
    }
}
