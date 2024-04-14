using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleChat.Models;

public class User{

    public int Id { get; set;}
    public string? Name { get; set;}
    public string? Surname {get; set;}
    public string? Email {get; set;}

    [InverseProperty("UserSender")]
    public ICollection<Message> UserSenderMessages { get; } = new List<Message>(); 

    [InverseProperty("UserReciever")]
    public ICollection<Message> UserRecieverMessages { get; } = new List<Message>(); 
    

    

    
}