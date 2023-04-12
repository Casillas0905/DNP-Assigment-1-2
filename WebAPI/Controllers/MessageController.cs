using Application.LogicInterfaces;
using Domain.DTOs;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    private readonly IMessageLogic messageLogic;

    public MessageController(IMessageLogic messageLogic)
    {
        this.messageLogic = messageLogic;
    }

    [HttpPost]
    public async Task<ActionResult<AnswerMessage>> CreateAsync(MessageCreationDto messageCreationDto)
    {
        try
        {
            AnswerMessage created = await messageLogic.CreateAsync(messageCreationDto);
            return Created($"/Message/{created.id}", created);
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
        
        
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<AnswerMessage>> GetById([FromRoute] int id)
    {
        try
        {
            AnswerMessage result = await messageLogic.GetByIdAsync(id);
            return Ok(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AnswerMessage>>> GetByPostId([FromQuery] int id)
    {
        try
        {
            IEnumerable<AnswerMessage> result = await messageLogic.GetByPostIdAsync(id);
            return Ok(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

}