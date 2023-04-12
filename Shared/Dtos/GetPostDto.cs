namespace Domain.DTOs;

public class GetPostDto
{
    public string Title { get; }
    public string Messages { get; }
    
    

    public GetPostDto(string title, string messages)
    {
       
        Title = title;
        Messages= messages;
    }
}