using FitWord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitWorld.Database.Repository
{
    public interface IMealRepo:IRepo<Meal>
    {
        public void Update(Meal meal);
    }
}
