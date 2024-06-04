using Olive.Leaves.System.Entities.DTOs;

namespace Olive.Leaves.System.Services.Interfaces
{
    public interface IFilterService<TViewModel>
        where TViewModel : class
    {
        Task<PaginatedDataViewModel<TViewModel>> GetPaginatedData(int pageNumber, int pageSize, CancellationToken cancellationToken);
        Task<PaginatedDataViewModel<TViewModel>> GetPaginatedData(int pageNumber, int pageSize, List<ExpressionFilter> filters);
        Task<PaginatedDataViewModel<TViewModel>> GetPaginatedData(int pageNumber, int pageSize, List<ExpressionFilter> filters, string sortBy, string sortOrder, CancellationToken cancellationToken);
    }
}
