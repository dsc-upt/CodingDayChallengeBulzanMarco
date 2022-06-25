using System.ComponentModel.DataAnnotations;

namespace CodeDay.Request;

public class UsersRequest
{
    public string Username { get; set; }
    [EmailAddress]public string Email { get; set; }
    public string Password { get; set; }
}