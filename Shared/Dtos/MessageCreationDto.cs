namespace Domain.DTOs;

public class MessageCreationDto
{
    public int Ownerid { get; }
    public int PostOwnerId { get; }
    public string Message { get; }

    public MessageCreationDto(int ownerid, int postOwnerId, string message)
    {
        Ownerid = ownerid;
        PostOwnerId = postOwnerId;
        Message = message;
    }
}
