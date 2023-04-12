using System.Net.Http.Json;
using System.Text.Json;
using Domain.DTOs;
using Domain.Models;
using HttpClients.ClientInterfaces;

namespace HttpClients.Implementations;

public class MessageHttpClient : IMessageService
{
    private readonly HttpClient client;

    public MessageHttpClient(HttpClient client)
    {
        this.client = client;
    }

    public async Task CreateAsync(MessageCreationDto dto)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("/answermessages",dto);
        if (!response.IsSuccessStatusCode)
        {
            string content = await response.Content.ReadAsStringAsync();
            throw new Exception(content);
        }
    }

    public async Task<AnswerMessage> GetById(int id)
    {
        HttpResponseMessage response = await client.GetAsync($"/answermessages/{id}");
        string result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result);
        }

        AnswerMessage posts = JsonSerializer.Deserialize<AnswerMessage>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return posts;
    }

    public Task<IEnumerable<AnswerMessage>> GetByPostIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}