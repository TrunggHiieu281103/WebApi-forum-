using System.Security.Claims;

namespace WedApi.Extensions
{
    public static class ClaimsExtensions
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            var claim = user.Claims.SingleOrDefault(x => x.Type.Equals("given_name"));
            return claim?.Value;
        }
    }
}
