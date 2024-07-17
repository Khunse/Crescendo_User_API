using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Crescendo_User.Infrastructure.Models
{
    [Table("Blog")]
    public class Blog : BaseModel
    {
        [PrimaryKey("id",false)]
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string Paragraph { get; set; } = null!;
        public string Image { get; set; } = null!;
        public string Categories { get; set; } = null!;
        public bool IsDelete { get; set; }
        public DateTime Created_at { get; set; }

    }

}