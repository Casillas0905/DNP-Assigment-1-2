using Application.DaoInterfaces;
using Application.LogicInterfaces;
using Domain.DTOs;
using Domain.Models;

namespace Application.Logic;

public class MessageLogic : IMessageLogic
{

    private readonly IMessageDao messageDao;
    private readonly IUserDao userDao;

    public MessageLogic(IMessageDao messageDao, IUserDao userDao)
    {
        this.messageDao = messageDao;
        this.userDao = userDao;
    }

    public async Task<AnswerMessage> CreateAsync(MessageCreationDto messageCreationDto)
    {
        User? user = await userDao.GetByIdAsync(messageCreationDto.Ownerid);
        if (user == null)
        {
            throw new Exception($"User with id {messageCreationDto.Ownerid} was not found.");
        }
        
        AnswerMessage message = new AnswerMessage(user, messageCreationDto.Message, messageCreationDto.PostOwnerId);
        AnswerMessage created = await messageDao.CreateAsync(message);
        return created;
    }



    public async Task<AnswerMessage> GetByIdAsync(int id)
    {
        AnswerMessage message = await messageDao.GetByIdAsync(id);
        if (message == null)
        {
            throw new Exception($"Post with id {id} not found");
        }

        return message;
    }

    public Task<IEnumerable<AnswerMessage>> GetByPostIdAsync(int id)
    {
        return messageDao.GetByPostId(id);
    }
}
