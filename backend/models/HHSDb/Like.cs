using System;

public class Like
{
    public int UserId { get; set; }

    public int PostId { get; set; }

    public DateTime LikedAt { get; set; } = DateTime.UtcNow;

    public User User { get; set; } = null!;

    public Post Post { get; set; } = null!;
}
