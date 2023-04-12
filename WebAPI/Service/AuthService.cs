using System.ComponentModel.DataAnnotations;
using Application.LogicInterfaces;
using Domain.DTOs;
using Domain.Models;

namespace WebAPI.Service;

public class AuthService : IAuthService
{
    private IUserLogic userLogic;

    public AuthService(IUserLogic userLogic)
    {
        this.userLogic = userLogic;
    }
    
    
    public async Task<User> ValidateUser(string username, string password)
    {
        Task<User> existingUser = userLogic.getByUsername(username);
        User user = await existingUser;
        
        if (existingUser == null)
        {
            throw new Exception("User not found");
        }

        if (!user.Password.Equals(password))
        {
            throw new Exception("Password mismatch");
        }

        return await existingUser;
    }

    
    public Task RegisterUser(User user)
    {

        if (string.IsNullOrEmpty(user.UserName))
        {
            throw new ValidationException("Username cannot be null");
        }

        if (string.IsNullOrEmpty(user.Password))
        {
            throw new ValidationException("Password cannot be null");
        }
        // Do more user info validation here
        
        // save to persistence instead of list
        
        UserCreationDto dto =
            new UserCreationDto(user.UserName, user.Password, user.Email, user.Name, user.SecurityLevel);
        userLogic.CreateAsync(dto);
        
        return Task.CompletedTask;
    }
}