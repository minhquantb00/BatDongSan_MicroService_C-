using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.QueryObjects
{
    public class SearchCriteriaObject
    {
        // Filtration
        public string? SearchTerm { get; set; }

        public string? FilterByColumn { get; set; }

        // Sorting
        public string? SortByColumn { get; set; }

        public bool SortDescending { get; set; }

        // Pagination
        public int PageNumber { get; set; }

        public int PageSize { get; set; }
    }
}
