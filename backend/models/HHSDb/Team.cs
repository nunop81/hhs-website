public class Team
{
    public string Name { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<Student> Students { get; set; } = new List<Student>();
}
