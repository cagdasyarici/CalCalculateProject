using CalCalculatorEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorDAL.Repositories
{
    public class BaseRepository<T> where T : class
    {
        CalCalculateDB _db= new CalCalculateDB();
        public void AddEntity(T entity) //Nesneyi Class fark etmeksizin database'e ekleyen metot..
        {
            _db.Set<T>().Add(entity);
            _db.SaveChanges();
        }

        public T FindEntity(int id) //Nesneyi Class fark etmeksizin id'sine göre getiren metot.
        { 
           return _db.Set<T>().Find(id);
        }

        public void RemoveEntity(T entity) //Neyneyi Class fark etmeksizin silen metot.
        {
            _db.Set<T>().Remove(entity);
            _db.SaveChanges();
        }

        public void UpdateEntity(T entity)
        {
            //_db.Set<T>().Update(entity);
        }

        public IQueryable<T> QueryableList() //Sorgulanabilir listeye çeviren metot.
        {
            return _db.Set<T>().AsQueryable();
        }
        public IList<T> BringTList()
        {
            return _db.Set<T>().ToList();
        }
        
    }
}
