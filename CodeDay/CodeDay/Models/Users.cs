using System.ComponentModel.DataAnnotations;

namespace CodeDay.Models;

public class Users : Entity
{
    public string Username { get; set; }
    [EmailAddress] public string Email { get; set; }
    public string Password { get; set; }
    public int Followers { get; set; }
}