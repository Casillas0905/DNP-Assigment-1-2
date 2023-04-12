using Application.DaoInterfaces;
using Domain.Models;

namespace FileData.DAOs;

public class MessageFileDao : IMessageDao
{
    private readonly FileContext context;
    
    public MessageFileDao(FileContext context)
    {
        this.context = context;
    }
    
    public Task<AnswerMessage> CreateAsync(AnswerMessage message)
    {
        int id = 1;
        if (context.AnswerMessages.Any())
        {
            id = context.AnswerMessages.Max(t => t.id);
            id++;
        }
        message.id = id;
        context.AnswerMessages.Add(message);
        context.SaveChanges();

        return Task.FromResult(message);
    }

    public Task<AnswerMessage> GetByIdAsync(int postId)
    {
        AnswerMessage result = context.AnswerMessages.FirstOrDefault(t => t.id == postId);
        return Task.FromResult(result);
    }

    public Task<IEnumerable<AnswerMessage>> GetByPostId(int id)
    {
        IEnumerable<AnswerMessage> messages = context.AnswerMessages.AsEnumerable();
        messages = context.AnswerMessages.Where(t => t.postOwnerid == id);
        return Task.FromResult(messages);
    }
}
