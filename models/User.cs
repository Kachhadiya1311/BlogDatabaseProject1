using Microsoft.Extensions.Hosting;
public class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string EmailAddress { get; set; }
    public string PhoneNumber { get; set; }
    public ICollection<Post> Posts { get; set; } = new List<Post>();
}