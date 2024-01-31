using FitWord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitWorld.Database.Repository
{
    public class PlanRepo : Repository<Plan>, IPlanRepo
    {
        private AppDbContext _db;
        public PlanRepo(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Plan plan)
        {
            _db.Update(plan);
        }

        
    }
}
