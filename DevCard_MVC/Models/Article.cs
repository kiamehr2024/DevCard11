namespace DevCard_MVC.Models
{
	public class Article
	{
		public long Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
	}
	public class IndexModel
	{
		public List<Project> Projects { get; set; }
		public List<Article> Articles { get; set; }
	}
}
