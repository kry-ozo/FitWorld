using FitWord.Models;
using FitWorld.Database;
using FitWorld.Database.Repository;
using FitWorld.Models.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace FitWord.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class MealsController : Controller
    {
        private readonly IUnitOfWork _db;
        private readonly UserManager<ApplicationUser> _userManager;
        

        public MealsController(IUnitOfWork db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            
            List<Meal> meals = (List<Meal>)_db.Meal.GetAll();
            if (meals != null)
            {
                return View(meals);
            }
            else
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
           
        }

        public IActionResult ShowMeal(int id)
        {
            Meal ?meal = _db.Meal.Find(id);
            if (meal != null)
            {
                return View(meal);
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            Meal? meal = _db.Meal.Find(id);
           
                return View(meal);
           
          
                
            
        }
        public IActionResult DownloadPdf(int mealId)
        {
            var meal = _db.Meal.Find(mealId);

            if (meal != null && meal.pdfMeal != null)
            {
                return File(meal.pdfMeal, "application/pdf", "Meal.pdf");
            }
            else
            {
                // Obsługa przypadku, gdy plik nie istnieje
                return NotFound();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Add(Meal meal, IFormFile pdfMeal)
        {
            var memoryStream = new MemoryStream();
            pdfMeal.CopyTo(memoryStream);
            meal.pdfMeal = memoryStream.ToArray();
            var user = await _userManager.GetUserAsync(User);
            meal.MealOwnerId = user.Id;
            _db.Meal.Add(meal);
            _db.Save();
            return RedirectToAction("Index");
           
           
        }

        [HttpPost]
        public IActionResult Delete(Meal obj) {
            
            int id = (int)obj.mealId;
            Meal meal= _db.Meal.Find(id);
            _db.Meal.Delete(meal);
            _db.Save();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Meal obj)
        {
            
            _db.Meal.Update(obj);
            _db.Save();
            return RedirectToAction("Index");
        }
    }
}
