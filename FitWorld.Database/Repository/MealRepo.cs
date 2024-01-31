using FitWord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitWorld.Database.Repository
{
    public class MealRepo : Repository<Meal>, IMealRepo
    {
        private AppDbContext _db;
        public MealRepo(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public Meal Find(int? mealId)
        {
            throw new NotImplementedException();
        }

        public void Update(Meal meal)
        {
            _db.Update(meal);
        }

        
    }
}
