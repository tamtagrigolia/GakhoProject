using Microsoft.AspNetCore.Mvc;
using PagedList.Mvc;
using PagedList;
namespace GakhoProject.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
