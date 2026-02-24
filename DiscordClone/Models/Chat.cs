using Microsoft.VisualBasic;

public class Chat
{
    [System.ComponentModel.DataAnnotations.Schema.Column("chatid")]
   public int ChatID {get; set;}
   [System.ComponentModel.DataAnnotations.Schema.Column("chatname")]
   public string ChatName {get; set;}

   [System.ComponentModel.DataAnnotations.Schema.Column("channelid")]
   public int ChannelID {get; set;}
   public Channel Channel {get; set;} = null!;

   [System.ComponentModel.DataAnnotations.Schema.Column("reqroleid")]
   public int RegRoleID  {get; set;}
   public Role ReqRole {get; set;} = null!;

   public ICollection<Msg> Msgs {get; set;} = new List<Msg>();
}