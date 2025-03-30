using System;
using System.Collections.Generic;

public class Post
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Content { get; set; } = null!;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public User User { get; set; } = null!;

    public ICollection<Like> Likes { get; set; } = new List<Like>();
}
