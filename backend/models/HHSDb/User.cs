using System;
using System.Collections.Generic;

public class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<Post> Posts { get; set; } = new List<Post>();

    public ICollection<Follow> Followers { get; set; } = new List<Follow>();

    public ICollection<Follow> Followees { get; set; } = new List<Follow>();

    public ICollection<Like> Likes { get; set; } = new List<Like>();
}
