using LAB11_WilliansMalque.Domain.IRepositories;
using LAB11_WilliansMalque.Infrastructure.Data;
using LAB11_WilliansMalque.Infrastructure.Repositories;

namespace LAB11_WilliansMalque.Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private ResponseRepository? _responseRepository;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public IResponseRepository ResponseRepository => 
        _responseRepository ??= new ResponseRepository(_context);

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
}