namespace Domain.DTOs;

public class PostCreationDto
{
    public int OwnerId { get; }
    public string Title { get; }
    
    public string Messages { get; }

    public PostCreationDto(int ownerId, string title, string messages)
    {
        OwnerId = ownerId;
        Title = title;
        Messages = messages;
    }
}