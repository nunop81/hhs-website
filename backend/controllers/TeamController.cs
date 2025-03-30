using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace;

[Route("api/[controller]")]
[ApiController]
public class TeamController(HHSDbContext hHSDbContext) : ControllerBase
{
    [HttpGet()]
    public IActionResult GetTeams()
    {
        var teams = hHSDbContext.Teams.ToList();
        return Ok(teams);
    }
    
    [HttpPost("add")]
    public IActionResult AddTeam(Team team)
    {
        hHSDbContext.Teams.Add(team);
        hHSDbContext.SaveChanges();
        return Ok(new { result = $"Team added: {team.Name}..." });
    }

    [HttpGet("{teamName}")]
    public IActionResult GetStudentsByTeam(string teamName)
    {
        var team = hHSDbContext.Students.Where(x=> x.Team == teamName).ToList();
        return Ok(team);
    }
}
