using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace DevCard_MVC.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var projects = new List<Project>()
			{
				new Project(1, "تاکسی", " درخواست انلاین تاکسی", "project-1.jpg","Atriya"),
				new Project(1, "زود فود", "درخواست انلاین غذا برای سراسر کشور", "project-2.jpg","ZoodFood"),
				new Project(1, "مدارس", "سیستم مدیریت یکپارچه مدارس", "project-3.jpg", "MONOP"),
				new Project(1, "فضاپیما", "برنامه مدیریت فضاپیماهای ناسا", "project-4.jpg", "NASA"),
			};
			return View("_Projects", projects);
		}
	}
}
