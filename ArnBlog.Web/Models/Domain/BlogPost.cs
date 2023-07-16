namespace ArnBlog.Web.Models.Domain
{
public class BlogPost {

        public Guid Id { get; set; }
        public string Heading { get; set; }
        public string Pagetitle { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }
        public string FeatureImageUrl { get; set; }
        public string UriHandle { get; set; }
        public DateTime PublishedDate { get; set; }

        public string Author { get; set; }

        public Boolean Visible { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }


}
