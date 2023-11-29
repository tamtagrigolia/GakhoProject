using Microsoft.AspNetCore.Mvc;
using PagedList.Mvc;
using PagedList;
using GakhoProject.Configuration;

namespace GakhoProject.Controllers
{
    public class MemberController : Controller
    {
		private readonly IUnitOfWork _unitOfWork;
        public MemberController(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }
		public async Task<IActionResult> Index()
		{
			try
			{
				var result = await _unitOfWork.MemberService.GetAllMembers();
				return View(result);
			}
			catch (Exception)
			{
				return RedirectToAction("Index");
			}
		}

	}
}
