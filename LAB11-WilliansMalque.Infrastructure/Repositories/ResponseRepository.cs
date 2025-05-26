using LAB11_WilliansMalque.Domain.IRepositories;
using LAB11_WilliansMalque.Infrastructure.Data;
using LAB11_WilliansMalque.Infrastructure.Models;

namespace LAB11_WilliansMalque.Infrastructure.Repositories;

public class ResponseRepository : IResponseRepository
{
    private readonly AppDbContext _context;

    public ResponseRepository(AppDbContext context)
    {
        _context = context;
    }

    public void Add(response entity)
    {
        _context.responses.Add(entity);
    }

    public async Task<response?> GetByIdAsync(Guid id)
    {
        return await _context.responses.FindAsync(id);
    }
}