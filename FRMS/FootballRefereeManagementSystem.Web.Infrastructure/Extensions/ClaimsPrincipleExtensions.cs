namespace FootballRefereeManagementSystem.Web.Infrastructure.Extensions
{
    using System.Security.Claims;

    public static class ClaimsPrincipleExtensions
    {
        public static string GetId(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
