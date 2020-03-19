namespace GpProject.Models
{
    public class Article : Post
    {
        public string Title { get; set; }

        public Article() : base() {
            this.Title = "";
        }
    }
}