﻿

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int BlogId { get; set; }
    public Blog Blog { get; set; }
    public int PostTypeId { get; set; }
    public PostType PostType { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}