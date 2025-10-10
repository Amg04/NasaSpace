using BLL.Interfaces;
using BLLProject.Interfaces;
using DAL.Data;
using Microsoft.EntityFrameworkCore.Storage;

namespace BLLProject.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        private IDbContextTransaction _transaction;
        public IKepoiDataRepository KepoiDataRepository { get; }

        public UnitOfWork(AppDbContext dbContext, IKepoiDataRepository kepoiDataRepository)
        {
            _dbContext = dbContext;
            KepoiDataRepository = kepoiDataRepository;
        }


        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public async Task BeginTransactionAsync()
        {
            _transaction = await _dbContext.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                await _transaction.CommitAsync();
            }
            finally
            {
                await _transaction.DisposeAsync();
            }
        }

        public async Task RollbackTransactionAsync()
        {
            await _transaction.RollbackAsync();
            await _transaction.DisposeAsync();
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _dbContext?.Dispose();
        }
    }
}