namespace Domain.DTOs;

public class SearchMessageDto
{
    public string? message { get;}
    public int? UserId { get;}
    public int? messageId { get;}

    public SearchMessageDto(string? message, int? userId, int? messageId)
    {
        this.message = message;
        UserId = userId;
        this.messageId = messageId;
    }
}