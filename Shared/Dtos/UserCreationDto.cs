namespace Domain.DTOs;

public class UserCreationDto
{
    public string UserName { get;}
    public string Password { get; }
    public string Email { get; }
    public string Name { get; }
    public int SecurityLevel { get; }

    public UserCreationDto(string userName, string password, string email, string name, int securityLevel)
    {
        UserName = userName;
        Password = password;
        Email = email;
        Name = name;
        SecurityLevel = securityLevel;
    }
}