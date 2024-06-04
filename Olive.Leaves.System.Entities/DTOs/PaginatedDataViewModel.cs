using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Olive.Leaves.System.Entities.DTOs
{
    public class PaginatedDataViewModel<T>
    {
        public IEnumerable<T> Data { get; set; }
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int PerPage { get; set; }

        public PaginatedDataViewModel(IEnumerable<T> data, int totalCount, int pagesize, int perPage)
        {
            Data = data;
            TotalCount = totalCount;
            PageSize = pagesize; 
        }

    }
}
