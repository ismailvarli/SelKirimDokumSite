namespace SelKirimDokumSite.Models
{
    public class BlogPost
    {
        public string Title { get; set; } = "";
        public string Slug { get; set; } = "";
        public string Excerpt { get; set; } = "";
        public string Content { get; set; } = "";
        public string? CoverImage { get; set; }
        public string? Date { get; set; }
        public string? Category { get; set; }
    }
}