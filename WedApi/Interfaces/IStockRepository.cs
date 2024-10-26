using WedApi.Dtos.Stock;
using WedApi.Helpers;
using WedApi.Models;

namespace WedApi.Interfaces
{
    public interface IStockRepository
    {
        Task<PagedResult<Stock>> GetAllAsync(QueryObject query);
        Task<Stock?> GetByIdAsync(int id); //First of Defaut can be null
        Task<Stock> CreateAsync(Stock stockModel);
        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        Task<Stock?> DeleteAsync(int id);
        Task<bool> StockExists(int id);
    }
}
