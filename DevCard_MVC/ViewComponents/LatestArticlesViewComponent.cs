using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1, "اموزش Asp.net Core mvc", "کاملترین پکیج اموزش asp.net core mvc به زبان فارسی", "blog-post-thumb-1.jpg"),
                new Article(2, "اموزش Git & GitHub", "کاملترین پکیج اموزش Git & GitHub به زبان فارسی", "blog-post-thumb-2.jpg"),
                new Article(3, "اموزش Onoin Architecture", "کاملترین پکیج اموزش Onoin Architecture به زبان فارسی", "blog-post-thumb-3.jpg"),
                new Article(4, "اموزش طراحی سایت", "کاملترین پکیج اموزش طراحی سایت به زبان فارسی", "blog-post-thumb-4.jpg"),


            };
            return View("_LatestArticles", articles);
        }
    }
}
