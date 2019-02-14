using MediatR;
using Drawers.Application.Infrastructure.Pagination;

namespace Drawers.Application.Customers.Queries.GetCustomersList
{
    public class GetCustomersListQuery: PaginatedQuery, IRequest<CustomersListViewModel>
    {
    }
}