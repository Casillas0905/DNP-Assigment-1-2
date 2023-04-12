namespace Domain.Models;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public int SecurityLevel { get; set; }

    public User()
    {
    }

    public User(string userName, string password, string email, string name, int securityLevel)
    {
        UserName = userName;
        Password = password;
        Email = email;
        Name = name;
        SecurityLevel = securityLevel;
    }
}