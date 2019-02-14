using MediatR;

namespace Drawers.Application.Customers.Commands.CreateCustomer
{

  public class CreateCustomerCommand : IRequest
  {
    public string Name { get; set; }
    public string Cpf { get; set; }
  }
}