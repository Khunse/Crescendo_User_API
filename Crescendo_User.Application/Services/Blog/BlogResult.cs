namespace Crescendo_User.Application.Services.Blog;

public record BlogResult(
    long Id,
    DateTime Created_date,
        string Title,
        string ImageUrl,
        string Paragraph,
        string[] Categories
);