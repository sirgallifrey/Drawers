namespace Drawers.Application.Infrastructure.Pagination
{
    public abstract class PaginatedQuery
    {
        public int Offset { get; set; }
        public int Limit { get; set; }
    }
}
