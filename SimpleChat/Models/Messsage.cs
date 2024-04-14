using System.ComponentModel.DataAnnotations.Schema;
using Azure.Identity;

namespace SimpleChat.Models;

public class Message{

    public int Id { get; set;}
    public string? Content { get; set;}
 
    [ForeignKey("UserSenderId")]
    public User UserSender { get; set;} = null!;
    public int UserSenderId {get; set;}


    [ForeignKey("UserRecieverId")]
    public User UserReciever { get; set;} = null!;
    public int UserRecieverId {get; set;}

    
}