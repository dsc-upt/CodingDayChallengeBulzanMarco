namespace CodeDay.Request;

public class PostRequest
{
    public string Creator { get; set; }
    public string Content { get; set; }
    public string[] Hashtag { get; set; }
}