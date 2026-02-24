using Microsoft.EntityFrameworkCore;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
  
    }
    
    //DB MODELS
    public DbSet<AppUser> AppUsers {get; set;} = null!;
    public DbSet<UserFriend> UserFriends {get; set;} = null!;
    public DbSet<Channel> Channels {get; set;} = null!;
    public DbSet<Role> Roles {get; set;} = null!;
    public DbSet<Chat> Chats {get; set;} = null!;
    public DbSet<Msg> Msg {get; set;} = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Table names to match to SQL
        modelBuilder.Entity<AppUser>().ToTable("app_user");
        modelBuilder.Entity<Channel>().ToTable("channel");
        modelBuilder.Entity<Chat>().ToTable("chat");
        modelBuilder.Entity<Msg>().ToTable("msg");
        modelBuilder.Entity<Role>().ToTable("roles");
        modelBuilder.Entity<UserFriend>().ToTable("user_friends");

        //Composite key for user_friends
        modelBuilder.Entity<UserFriend>()
            .HasKey(uf => new { uf.SenderID, uf.ReceiverID});

        modelBuilder.Entity<UserFriend>()
            .HasOne(uf => uf.Sender)
            .WithMany(u => u.SentFriendRequests)
            .HasForeignKey(uf => uf.SenderID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<UserFriend>()
            .HasOne(uf => uf.Receiver)
            .WithMany( u => u.ReceivedFriendRequests)
            .HasForeignKey(uf => uf.ReceiverID)
            .OnDelete(DeleteBehavior.Restrict);
        
        //Channel Relationships
        modelBuilder.Entity<Channel>()
            .HasOne( c => c.Creator)
            .WithMany(u => u.CreatedChannels)
            .HasForeignKey(c => c.CreatorID);

        //Chat Relationships
        modelBuilder.Entity<Chat>()
            .HasOne(c => c.Channel)
            .WithMany( ch => ch.Chats)
            .HasForeignKey(c => c.ChannelID);

        modelBuilder.Entity<Chat>()
            .HasOne(c => c.ReqRole)
            .WithMany()
            .HasForeignKey(c => c.RegRoleID)
            .OnDelete(DeleteBehavior.SetNull);

        //Role Relationships
        modelBuilder.Entity<Role>()
            .HasOne( r => r.Channel)
            .WithMany(c => c.Roles)
            .HasForeignKey(r => r.ChannelID);

        //Message Relationships
        modelBuilder.Entity<Msg>()
            .HasOne(m => m.Chat)
            .WithMany(c => c.Msgs)
            .HasForeignKey(m => m.ChatID);

        modelBuilder.Entity<Msg>()
            .HasOne(m => m.User)
            .WithMany(u => u.Msgs)
            .HasForeignKey(m => m.UserID);
    }

}
