using Domain.Models;

namespace WebAPI.Service;

public interface IAuthService
{
    Task<User> ValidateUser(string username, string password);
    Task RegisterUser(User user);
}