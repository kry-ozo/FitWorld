using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitWorld.Database.Repository
{
    public interface IRepo<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Find(int id);
        void Delete(T item);
        void Add(T item);
        
    }
}
