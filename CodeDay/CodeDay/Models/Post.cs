namespace CodeDay.Models;

public class Post : Users
{
    public string Creator { get; set; }
    public string Content { get; set; }
    public string[] Hashtags { get; set; }
    public int Likes { get; set; }
}