using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace;

[Route("api/[controller]")]
[ApiController]
public class UserController(HHSDbContext hHSDbContext) : ControllerBase
{
    [HttpGet]
    public IActionResult GetUsers()
    {
        var users = hHSDbContext.Users.ToList();
        return Ok(users);
    }

    [HttpPost("add")]
    public IActionResult AddUser(User user)
    {
        hHSDbContext.Users.Add(user);
        hHSDbContext.SaveChanges();
        return Ok(new { result = $"User Created: {user.Username}..." });
    }

    [HttpGet("{id}")]
    public IActionResult GetUserById(int id)
    {
        var user = hHSDbContext.Users.FirstOrDefault(x => x.Id == id);
        return Ok(user);
    }
}
