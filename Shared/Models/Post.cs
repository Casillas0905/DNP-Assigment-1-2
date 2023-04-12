namespace Domain.Models;

public class Post
{
    public int Id { get; set; }
    public User Owner { get; }
    public string Title { get; }
    
    public string Messages { get; }
    

    public Post(User owner, string title, String messages)
    {
        Owner = owner;
        Title = title;
        Messages = messages;
    }
}