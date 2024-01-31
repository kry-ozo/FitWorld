using FitWord.Models;
using FitWorld.Database;
using FitWorld.Database.Repository;
using FitWorld.Models.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitWord.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class PlansController : Controller
    {
        private  IUnitOfWork _db {  get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        public PlansController(IUnitOfWork db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            
            List<Plan> plans = (List<Plan>)_db.Plan.GetAll();
            if(plans==null || plans.Count == 0)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return View(plans);
        }

        public IActionResult ShowPlan(int id)
        {
            Plan plan = _db.Plan.Find(id);
            if (plan == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return View(plan);
        }
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult DownloadPdf(int planId)
        {
            var plan = _db.Plan.Find(planId);

            if (plan != null && plan.pdfPlan != null)
            {
                return File(plan.pdfPlan, "application/pdf", "Meal.pdf");
            }
            else
            {
                // Obsługa przypadku, gdy plik nie istnieje
                return NotFound();
            }
        }

        public IActionResult Edit(int id)
        {
            Plan plan = _db.Plan.Find(id);
            if (plan == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return View(plan);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Plan plan,IFormFile pdfPlan)
        {
            var memoryStream = new MemoryStream();
            pdfPlan.CopyTo(memoryStream);
            plan.pdfPlan = memoryStream.ToArray();
            var user = await _userManager.GetUserAsync(User);
            plan.PlanOwnerId = user.Id;
            _db.Plan.Add(plan);
            _db.Save();
            return RedirectToAction("Index");  
        }

        [HttpPost]
        public IActionResult Edit(Plan plan)
        {
           
            _db.Plan.Update(plan);
            _db.Save();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(Plan plan)
        {
            
            Plan planToDelete =_db.Plan.Find(plan.planId);
            _db.Plan.Delete(planToDelete);
            _db.Save();
            return RedirectToAction("Index");
        }
    }
}
