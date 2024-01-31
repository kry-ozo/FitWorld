using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitWorld.Database.Repository
{
    public class Repository<T> : IRepo<T> where T : class
    {
        private AppDbContext _db;
        private DbSet<T> _dbSet;
        

        public Repository(AppDbContext db)
        {
            
            _db = db;
            this._dbSet = db.Set<T>();
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
        }

        public void Delete(T item)
        {
            _dbSet.Remove(item);
        }

        public T Find(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
           return _dbSet.ToList();
        }
    }
}
