using Microsoft.EntityFrameworkCore;
using Olive.Leaves.System.Data;
using Olive.Leaves.System.Entities.DTOs;
using Olive.Leaves.System.Services.Interfaces.IRepositories;

namespace Olive.Leaves.System.Services.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly AppDbContext _dbContext;
        protected DbSet<T> DbSet => _dbContext.Set<T>();

        public BaseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public virtual async Task<PaginatedDataViewModel<T>> GetPaginatedData(int pageNumber, int pageSize, CancellationToken cancellationToken)
        {
            var query = _dbContext.Set<T>()
                                    .Skip((pageNumber - 1) * pageSize)
                                    .Take(pageSize)
                                    .AsNoTracking();

            var data = await query.ToListAsync(cancellationToken);
            var totalCount = await _dbContext.Set<T>().CountAsync(cancellationToken);

            return new PaginatedDataViewModel<T>(data, totalCount, pageNumber, pageSize);
        }

        public async Task<PaginatedDataViewModel<T>> GetPaginatedData(int pageNumber, int pageSize, List<ExpressionFilter> filters)
        {
            var query = _dbContext.Set<T>().AsNoTracking();

            // Apply search criteria if provided
            if (filters != null && filters.Any())
            {
                var expressionTree = ExpressionBuilder.ConstructAndExpressionTree<T>(filters);
                query = query.Where(expressionTree);
            }

            // Pagination
            var data = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var totalCount = await query.CountAsync();

            return new PaginatedDataViewModel<T>(data, totalCount, pageNumber, pageSize);
        }

        public Task<PaginatedDataViewModel<T>> GetPaginatedData(int pageNumber, int pageSize, List<ExpressionFilter> filters, string sortBy, string sortOrder, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

    }
}
