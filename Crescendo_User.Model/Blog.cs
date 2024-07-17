namespace Crescendo_User.Models;

    public record BlogViewModel(
        DateTime Created_date,
        string Title,
        string ImageUrl,
        string Paragraph,
        string[] Categories
    );