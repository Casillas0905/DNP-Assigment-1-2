namespace Domain.DTOs;

public class PostBasicDto
{
    public int Id { get; }
    public string OwnerName { get; }
    public string Title { get; }
    public string Messages { get; }
    
    

    public PostBasicDto(int id, string ownerName, string title, string messages)
    {
        Id = id;
        OwnerName = ownerName;
        Title = title;
        Messages= messages;
    }
}