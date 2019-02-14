using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Drawers.Domain.Entities;
using Drawers.Domain.ValueObjects;
using Drawers.Persistence;

namespace Drawers.Application.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Unit>
    {
        private readonly DrawersDbContext _context;

        public CreateCustomerCommandHandler(DrawersDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var entity = new Customer
            {
                Name = request.Name
            };

            _context.Customers.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
