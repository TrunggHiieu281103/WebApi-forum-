using WedApi.Models;

namespace WedApi.Interfaces
{
    public interface IPortfolioRepository
    {
        Task<List<Stock>> GetUserProtfolio(AppUser user);
    }
}
