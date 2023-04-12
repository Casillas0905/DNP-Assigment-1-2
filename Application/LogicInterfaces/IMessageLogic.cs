using Domain.DTOs;
using Domain.Models;

namespace Application.LogicInterfaces;

public interface IMessageLogic
{
    Task<AnswerMessage> CreateAsync(MessageCreationDto messageCreationDto);
    Task<AnswerMessage> GetByIdAsync(int id);

    Task<IEnumerable<AnswerMessage>> GetByPostIdAsync(int id);
}
