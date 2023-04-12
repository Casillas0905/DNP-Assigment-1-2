namespace Domain.Models;

public class AnswerMessage
{
    public User Owner { get;}
    public int id { get; set; }
    public string message { get; }
    public int postOwnerid { get; }

    public AnswerMessage(User owner, string message, int postOwnerid)
    {
        Owner = owner;
        this.message = message;
        this.postOwnerid = postOwnerid;
    }
}