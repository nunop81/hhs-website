using System;

public class Follow
{
    public int FollowerId { get; set; }

    public int FolloweeId { get; set; }

    public DateTime FollowedAt { get; set; } = DateTime.UtcNow;

    public User Follower { get; set; } = null!;

    public User Followee { get; set; } = null!;
}
