using GakhoProject.Configuration;
using GakhoProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GakhoProject.Controllers
{
    [Authorize]

    public class PolitPartieController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;
		public PolitPartieController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public async Task<IActionResult> Index()
		{
			try
			{
				var result = await _unitOfWork.PolitPartieService.GetAllPolitParties();
				return View(result);
			}
			catch (Exception)
			{
				return RedirectToAction("Index");
			}
		}
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var result = await _unitOfWork.PolitPartieService.GetPolitParts(id);
                return View(result);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var result = await _unitOfWork.PolitPartieService.GetPolitParts(id);
                return View(result);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await _unitOfWork.PolitPartieService.GetPolitParts(id);
                return View(result);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Delete(PolitParties model)
        {
            try
            {
                await _unitOfWork.PolitPartieService.DeletePolitParties(model);
                await _unitOfWork.Save();
            }
            catch (Exception)
            {
            }

            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PolitParties model)
        {
            try
            {
                if (ModelState.IsValid) 
                {
                    await _unitOfWork.PolitPartieService.Add(model);
                    await _unitOfWork.Save();
                }
            }
            catch (Exception)
            {
            }

            return RedirectToAction("Index");
        }
    }
}
