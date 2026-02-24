public class Role()
{
    [System.ComponentModel.DataAnnotations.Schema.Column("roleid")]
    public int RoleID {get; set;}
    [System.ComponentModel.DataAnnotations.Schema.Column("rolename")]
    public string RoleName {get; set;}

    [System.ComponentModel.DataAnnotations.Schema.Column("channelid")]
    public int ChannelID {get; set;}
    public Channel Channel {get; set;} = null!;
}