using Microsoft.EntityFrameworkCore;
using SaleSystemR.Domain.Repositories;
using SaleSystemR.Domain.Result;
using SaleSystemR.Persistence.Context;

namespace SaleSystemR.Persistence.Base
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly SaleSystemRContext _saleSystemRContext;
        private DbSet<TEntity> entities;

        public BaseRepository(SaleSystemRContext saleSystemRContext)
        {
            _saleSystemRContext = saleSystemRContext;
            this.entities = _saleSystemRContext.Set<TEntity>();
        }

        public virtual async Task<OperationResult> GetAll()
        {
            OperationResult operationResult = new OperationResult();
            try
            {
                var data = await this.entities.ToListAsync();
                operationResult.Data = data;
            }
            catch (Exception ex)
            {
                operationResult.Success = false;
                operationResult.Message = $"An error has ocurred {ex.Message} when obtaining the registry.";
            }
            return operationResult;
        }

        public virtual async Task<OperationResult> Remove(TEntity entity)
        {
            OperationResult operationResult = new OperationResult();
            try
            {
                entities.Remove(entity);
                await _saleSystemRContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                operationResult.Success = false;
                operationResult.Message = $"An error has ocurred {ex.Message} removing the entity.";
            }
            return operationResult;
        }

        public virtual async Task<OperationResult> Save(TEntity entity)
        {
            OperationResult operationResult = new OperationResult();
            try
            {
                entities.Add(entity);
                await _saleSystemRContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                operationResult.Success = false;
                operationResult.Message = $"An error has ocurred {ex.Message} saving the entity.";
            }
            return operationResult;
        }

        public virtual async Task<OperationResult> Update(TEntity entity)
        {
            OperationResult operationResult = new OperationResult();
            try
            {
                entities.Update(entity);
                await _saleSystemRContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                operationResult.Success = false;
                operationResult.Message = $"An error has ocurred {ex.Message} updating the entity.";
            }
            return operationResult;
        }
    }
}
