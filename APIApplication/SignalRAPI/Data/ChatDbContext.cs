using Microsoft.EntityFrameworkCore;

namespace SignalRAPI.Data
{
    public class ChatDbContext(DbContextOptions<ChatDbContext> options) : DbContext(options)
    {
        public DbSet<ChatMessageEntity> ChatMessages => Set<ChatMessageEntity>();
        protected override void OnModelCreating(ModelBuilder b)
        {
            b.Entity<ChatMessageEntity>(e =>
            {
                e.ToTable("ChatMessages");
                e.HasKey(x => x.Id);
                e.Property(x => x.User).HasMaxLength(64).IsRequired();
                e.Property(x => x.Text).HasMaxLength(2000).IsRequired();
                e.Property(x => x.Room).HasMaxLength(64);
                e.HasIndex(x => new { x.Room, x.At });
            });
        }
    }
}
