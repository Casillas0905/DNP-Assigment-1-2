using Domain.DTOs;
using Domain.Models;

namespace Application.DaoInterfaces;

public interface IMessageDao
{
    Task<AnswerMessage> CreateAsync(AnswerMessage message);
    Task<AnswerMessage> GetByIdAsync(int postId);
    Task<IEnumerable<AnswerMessage>> GetByPostId(int id);
}
