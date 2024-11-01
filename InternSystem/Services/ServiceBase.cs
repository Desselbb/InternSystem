using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternSystemClassLibrary;
using InternSystemCore.Data;

namespace InternSystemClassLibrary.Services
{
    public abstract class ServiceBase<T> where T : class
    {

        protected readonly SystemDbContext db;
        public ServiceBase(SystemDbContext _db)
        {
            db = _db;
        }

        public T Get(int id)
        {
            return db.Set<T>().Find(id);
        }
        public bool Add(T entity)
        {
            try
            {
                db.Set<T>().Add(entity);
                db.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool Update(T entity)
        {
            try
            {
                db.Set<T>().Update(entity);
                db.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool Delete(T entity)
        {
            try
            {
                db.Set<T>().Remove(entity);
                db.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }
        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }
    }
}

