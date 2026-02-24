using System.Reflection.Metadata;

public class Msg
{
   [System.ComponentModel.DataAnnotations.Schema.Column("msgid")]
   public int MsgID {get; set;}
   [System.ComponentModel.DataAnnotations.Schema.Column("msgcontent")]
   public string MsgContent {get; set;}
   [System.ComponentModel.DataAnnotations.Schema.Column("msgdate")]
   public DateTime MsgDate {get; set;} = DateTime.Now;

   public Chat Chat {get; set;} = null!;
   [System.ComponentModel.DataAnnotations.Schema.Column("chatid")]
   public int ChatID {get; set;}
   public AppUser User {get;set;} = null!;
   [System.ComponentModel.DataAnnotations.Schema.Column("userid")]
   public int UserID {get; set;}
}