using Microsoft.EntityFrameworkCore;

namespace SimpleChat.Models;

public class SimpleChatContext : DbContext
{
    public SimpleChatContext(DbContextOptions<SimpleChatContext> options)
        : base(options)
    {
    }

    public DbSet<User> users { get; set; } = null!;
    public DbSet<Message> messages { get; set; } = null!;
}