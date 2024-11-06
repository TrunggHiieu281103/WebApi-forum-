using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WedApi.Extensions;
using WedApi.Interfaces;
using WedApi.Models;
using WedApi.Repository;

namespace WedApi.Controllers
{
    [Route("api/portfolio")]
    [ApiController]
    public class ProtfolioController : ControllerBase
    {
        private readonly IStockRepository _stockRepo;
        private readonly IPortfolioRepository _portfolioRepo;
        private readonly UserManager<AppUser> _userManager;
        public ProtfolioController(UserManager<AppUser> userManager, IStockRepository stockRepo,
                    IPortfolioRepository portfolioRepo)
        {
            _stockRepo = stockRepo;
            _userManager = userManager;
            _portfolioRepo = portfolioRepo;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetUserProtfolio()
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);
            var userPortfolio = await _portfolioRepo.GetUserProtfolio(appUser);
            return Ok(userPortfolio);
        }
    }
}
