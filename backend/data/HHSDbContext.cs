using Microsoft.EntityFrameworkCore;

public class HHSDbContext : DbContext
{
    public HHSDbContext(DbContextOptions<HHSDbContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Like>()
            .HasKey(l => new { l.UserId, l.PostId });

        // Composite key
        modelBuilder.Entity<Follow>()
            .HasKey(f => new { f.FollowerId, f.FolloweeId });

        // Follower relationship
        modelBuilder.Entity<Follow>()
            .HasOne(f => f.Follower)
            .WithMany(u => u.Followees) // Users that *this user* follows
            .HasForeignKey(f => f.FollowerId)
            .OnDelete(DeleteBehavior.Cascade);

        // Followee relationship
        modelBuilder.Entity<Follow>()
            .HasOne(f => f.Followee)
            .WithMany(u => u.Followers) // Users that *follow this user*
            .HasForeignKey(f => f.FolloweeId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Team>()
            .HasKey(x => x.Name);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Like> Likes { get; set; }
    public DbSet<Follow> Follows { get; set; }
}
