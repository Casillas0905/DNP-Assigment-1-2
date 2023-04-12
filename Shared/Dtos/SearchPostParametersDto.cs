namespace Domain.DTOs;

public class SearchPostParametersDto
{
    public string? Username { get;}
    public int? UserId { get;}
    public string? TitleContains { get;}
    public string? Message { get; }

    public SearchPostParametersDto(string? username, int? userId, string? titleContains, string? message)
    {
        Username = username;
        UserId = userId;
        TitleContains = titleContains;
        Message = message;
    }
}