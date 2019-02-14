using System;
using System.Collections.Generic;

namespace Drawers.Application.Infrastructure.Pagination {
    public abstract class PaginatedModel<T>
    {
        public PaginatedMetadataModel _metadata { get; set; }
        public ICollection<T> Records { get; set; }
    }
}