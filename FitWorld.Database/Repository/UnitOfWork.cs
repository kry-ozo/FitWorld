using FitWord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitWorld.Database.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _db;
        public IPlanRepo Plan { get; private set; }

        

        public IMealRepo Meal { get; private set; }

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            Plan = new PlanRepo(_db);
            Meal = new MealRepo(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
