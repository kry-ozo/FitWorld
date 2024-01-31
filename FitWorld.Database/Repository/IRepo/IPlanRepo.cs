using FitWord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitWorld.Database.Repository
{
    public interface IPlanRepo: IRepo<Plan>
    {
        public void Update(Plan plan);
    }
}
