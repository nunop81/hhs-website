
public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Team { get; set; } = null!;
    public string Role { get; set; } = null!;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
