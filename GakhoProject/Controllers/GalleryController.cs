using Microsoft.AspNetCore.Mvc;

namespace GakhoProject.Controllers
{
	public class GalleryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
