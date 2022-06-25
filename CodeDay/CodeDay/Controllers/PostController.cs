using CodeDay.Database;
using CodeDay.Models;
using CodeDay.Request;
using CodeDay.Response;
using Microsoft.AspNetCore.Mvc;

namespace CodeDay.Controllers;

[ApiController]
[Route("Api/Post")]
public class PostController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public PostController(AppDbContext appDbContext)
    {
        _dbContext = appDbContext;
    }
    
    [HttpPost("Add")]
    public async Task<ActionResult<UsersResponse>> AddUser([FromBody] UsersRequest userRequest)
    {
        Random rnd = new Random();
        var user = new Users
        {
            Id = Guid.NewGuid().ToString(),
            Created = DateTime.UtcNow,
            Updated = DateTime.UtcNow,
            Username = userRequest.Username,
            Email = userRequest.Email,
            Password = userRequest.Password,
            Followers = rnd.Next(0, 1000)
        };

        await _dbContext.Users.AddAsync(user);
        await _dbContext.SaveChangesAsync();

        return Ok(new UsersResponse
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email,
            Followers = user.Followers
        });
    }
}