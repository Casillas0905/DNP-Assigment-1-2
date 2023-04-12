using Domain.DTOs;

namespace Test;

public class Class1
{
    public void print(UserCreationDto user)
    {
        Console.WriteLine(user.UserName);
        Console.WriteLine(user.Password);
        Console.WriteLine(user.Email);
        Console.WriteLine(user.Name);
        Console.WriteLine(user.SecurityLevel);
    }

}