using System;
using System.Collections.Generic;

namespace Drawers.Application.Infrastructure.Pagination {
    public class PaginatedMetadataModel
    {
        public int Page { get; set; }
        public int PerPage { get; set; }
        public int PageCount { get; set; }
        public int TotalCount { get; set; }
    }
}