public class Channel
{
   [System.ComponentModel.DataAnnotations.Schema.Column("channelid")]
   public int ChannelID {get; set;}
   [System.ComponentModel.DataAnnotations.Schema.Column("channelname")]
   public string ChannelName {get; set;}

   [System.ComponentModel.DataAnnotations.Schema.Column("creatorid")]
   public int CreatorID {get; set;}
   public AppUser Creator {get; set;} = null!;

   public ICollection<Role> Roles {get; set;} = new List<Role>();
   public ICollection<Chat> Chats {get; set;} = new List<Chat>();
    
}