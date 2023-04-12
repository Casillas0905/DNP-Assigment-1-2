using Domain.DTOs;
using Domain.Models;

namespace HttpClients.ClientInterfaces;

public interface IMessageService
{
    Task CreateAsync(MessageCreationDto message);
    Task<AnswerMessage> GetById(int id);
    Task<IEnumerable<AnswerMessage>> GetByPostIdAsync(int id);
}