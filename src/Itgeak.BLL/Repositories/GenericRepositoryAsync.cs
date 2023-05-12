using Itgeak.DAL.Data;
using Itgeak.DAL.Interfaces;

namespace Itgeak.BLL.Repositories;

public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : class
{
    private readonly AppDbContext _db;
    public GenericRepositoryAsync(AppDbContext db)
    {
        _db = db;
    }
    public Task<IReadOnlyList<T>> ListAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIDAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<T> InsertAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<T>> GetPagedAsync(int page, int size)
    {
        throw new NotImplementedException();
    }
}