public class UserFriend()
{
    public AppUser Sender {get; set;} = null!;
    [System.ComponentModel.DataAnnotations.Schema.Column("senderid")]
    public int SenderID {get;set;}
    public AppUser Receiver {get; set;} = null!;
    [System.ComponentModel.DataAnnotations.Schema.Column("recieverid")]
    public int ReceiverID {get; set;}

    [System.ComponentModel.DataAnnotations.Schema.Column("status")]
    public string RequestStatus {get; set;} = "pending";
}