using Olive.Leaves.System.Entities.DTOs;
using Olive.Leaves.System.Services.Interfaces;
using Olive.Leaves.System.Services.Interfaces.IMapper;
using Olive.Leaves.System.Services.Interfaces.IRepositories;

namespace Olive.Leaves.System.Services
{
    //public class FilterService<T, TViewModel> : IFilterService<TViewModel> where T : class
    //    where TViewModel : class
    //{
    //    private readonly IBaseMapper<T, TViewModel> _viewModelMapper;
    //    private readonly IBaseRepository<T> _repository;

    //    public FilterService(IBaseMapper<T, TViewModel> viewModelMapper, IBaseRepository<T> repository)
    //    {
    //        _viewModelMapper = viewModelMapper;
    //        _repository = repository;
    //    }
    //    public async Task<PaginatedDataViewModel<TViewModel>> GetPaginatedData(int pageNumber, int pageSize, CancellationToken cancellationToken)
    //    {
    //        var paginatedData = await _repository.GetPaginatedData(pageNumber, pageSize, cancellationToken);
    //        var mappedData = _viewModelMapper.MapList(paginatedData.Data);
    //        var paginatedDataViewModel = new PaginatedDataViewModel<TViewModel>(mappedData.ToList(), paginatedData.TotalCount, pageNumber, pageSize);
    //        return paginatedDataViewModel;
    //    }

    //    public async Task<PaginatedDataViewModel<TViewModel>> GetPaginatedData(int pageNumber, int pageSize, List<ExpressionFilter> filters)
    //    {
    //        //var paginatedData = await _repository.GetPaginatedData(pageNumber, pageSize, filters);
    //        //var mappedData = _viewModelMapper.MapList(paginatedData.Data);
    //        //var paginatedDataViewModel = new PaginatedDataViewModel<TViewModel>(paginatedData.ToList(), paginatedData.TotalCount, pageNumber, pageSize);
    //        //return paginatedDataViewModel;
    //        return null;
    //    }

    //    public async Task<PaginatedDataViewModel<TViewModel>> GetPaginatedData(int pageNumber, int pageSize, List<ExpressionFilter> filters, string sortBy, string sortOrder, CancellationToken cancellationToken)
    //    {
    //        var paginatedData = await _repository.GetPaginatedData(pageNumber, pageSize, filters, sortBy, sortOrder, cancellationToken);
    //        var mappedData = _viewModelMapper.MapList(paginatedData.Data);
    //        var paginatedDataViewModel = new PaginatedDataViewModel<TViewModel>(mappedData.ToList(), paginatedData.TotalCount, pageNumber, pageSize);
    //        return paginatedDataViewModel;
    //    }
    //}
}
