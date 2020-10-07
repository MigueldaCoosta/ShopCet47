using Microsoft.AspNetCore.Identity;
using ShopCet47.Web.Data.Entities;
using System.Threading.Tasks;

namespace ShopCet47.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetuUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);
    }
}
