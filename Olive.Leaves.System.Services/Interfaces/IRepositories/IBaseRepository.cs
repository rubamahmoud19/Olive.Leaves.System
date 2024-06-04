using Olive.Leaves.System.Entities.DTOs;

namespace Olive.Leaves.System.Services.Interfaces.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<PaginatedDataViewModel<T>> GetPaginatedData(int pageNumber, int pageSize, CancellationToken cancellationToken);
        Task<PaginatedDataViewModel<T>> GetPaginatedData(int pageNumber, int pageSize, List<ExpressionFilter> filters);
        Task<PaginatedDataViewModel<T>> GetPaginatedData(int pageNumber, int pageSize, List<ExpressionFilter> filters, string sortBy, string sortOrder, CancellationToken cancellationToken);
    }
}
