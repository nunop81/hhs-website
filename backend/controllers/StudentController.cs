using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace;

[Route("api/[controller]")]
[ApiController]
public class StudentController(HHSDbContext hHSDbContext) : ControllerBase
{    
    [HttpGet()]
    public IActionResult GetStudents()
    {
        var teams = hHSDbContext.Students.ToList();
        return Ok(teams);
    }

    [HttpPost("add")]
    public IActionResult AddStudents(List<Student> students)
    {
        hHSDbContext.Students.AddRange(students);
        hHSDbContext.SaveChanges();
        return Ok(students);
    }

    [HttpGet("{id}")]
    public IActionResult GetStudentById(int id)
    {
        var student = hHSDbContext.Students.FirstOrDefault(x=> x.Id == id);
        return Ok(student);
    }
}
