using System;
using System.Linq;

class Program
{
    static void Main()
    {

        using (var context = new AppDbContext())
        {
            // Add Users
            var user1 = new User { Name = "John Doe", EmailAddress = "john@example.com", PhoneNumber = "1234567890" };
            var user2 = new User { Name = "Jane Smith", EmailAddress = "jane@example.com", PhoneNumber = "0987654321" };
            var user3 = new User { Name = "Mike Johnson", EmailAddress = "mike@example.com", PhoneNumber = "1122334455" };

            context.Users.AddRange(user1, user2, user3);
            context.SaveChanges();

            // Add Blog Type
            var blogType = new BlogType { Status = "Active", Name = "Tech", Description = "Technology-related blogs" };
            context.BlogTypes.Add(blogType);
            context.SaveChanges();

            // Add Post Type
            var postType = new PostType { Status = "Published", Name = "Article", Description = "Long-form articles" };
            context.PostTypes.Add(postType);
            context.SaveChanges();

            // Add Blog
            var blog = new Blog { Url = "https://mytechblog.com", IsPublic = true, BlogTypeId = blogType.BlogTypeId };
            context.Blogs.Add(blog);
            context.SaveChanges();

            // Add a Post
            var post = new Post
            {
                Title = "Introduction to AI",
                Content = "This post explains the basics of AI...",
                BlogId = blog.BlogId,
                PostTypeId = postType.PostTypeId,
                UserId = user1.UserId
            };

            context.Posts.Add(post);
            context.SaveChanges();

            Console.WriteLine("Data added successfully!");
        }
    }
}
