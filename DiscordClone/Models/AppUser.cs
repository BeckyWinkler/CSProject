using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

public class AppUser
{
    [Key]
    [System.ComponentModel.DataAnnotations.Schema.Column("userid")]
    public int UserID {get; set;}

    [System.ComponentModel.DataAnnotations.Schema.Column("username")]
    public string UserName {get; set;}
    [System.ComponentModel.DataAnnotations.Schema.Column("userpassword")]
    public string UserPassword {get; set;}
    [System.ComponentModel.DataAnnotations.Schema.Column("email")]
    public string Email {get; set;}
    
    //relationships
    public ICollection<Channel> CreatedChannels {get; set;} = new List<Channel>();
    public ICollection<Msg> Msgs {get; set;} = new List<Msg>();

    public ICollection<UserFriend> SentFriendRequests {get; set;} = new List<UserFriend>();
    public ICollection<UserFriend> ReceivedFriendRequests {get; set;} = new List<UserFriend>();
    
}