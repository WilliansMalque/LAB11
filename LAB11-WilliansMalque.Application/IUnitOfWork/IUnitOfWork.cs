using LAB11_WilliansMalque.Domain.IRepositories;

namespace LAB11_WilliansMalque.Application.IUnitOfWork;

public interface IUnitOfWork
{
    IResponseRepository ResponseRepository { get; }
    Task CompleteAsync();
}