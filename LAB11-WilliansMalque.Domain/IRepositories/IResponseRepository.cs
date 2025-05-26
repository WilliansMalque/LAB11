namespace LAB11_WilliansMalque.Domain.IRepositories;

public interface IResponseRepository
{
    void Add(response entity);
    Task<response?> GetByIdAsync(Guid id);
    // Otros métodos que necesites...
}