using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Drawers.Persistence;

namespace Drawers.Application.Customers.Queries.GetCustomersList
{
    public class GetCustomersListQueryHandler : IRequestHandler<GetCustomersListQuery, CustomersListViewModel>
    {
        private readonly DrawersDbContext _context;

        public GetCustomersListQueryHandler(DrawersDbContext context)
        {
            _context = context;
        }

        public async Task<CustomersListViewModel> Handle(GetCustomersListQuery request, CancellationToken cancellationToken)
        {
            var vm = new CustomersListViewModel
            {
                Records = await _context.Customers.Select(c =>
                    new CustomerLookupViewModel
                    {
                        Id = c.Id,
                        Name = c.Name
                    }).ToListAsync(cancellationToken)
            };

            return vm;
        }
    }
}