using BLLProject.Interfaces;

namespace BLL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IKepoiDataRepository KepoiDataRepository { get; }
        Task<int> SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}
