using WedApi.Models;

namespace WedApi.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
