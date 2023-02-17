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
        public void DatabaseRemove(FoodMeal foodMeal)
        {
            _db.Remove(foodMeal); // Value Cannot Be Null Hatası
            _db.SaveChanges();  
        }
        public bool AddEntity(T entity) //Nesneyi Class fark etmeksizin database'e ekleyen metot..
        {
            try
            {
                _db.Set<T>().Add(entity);
                _db.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
                
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
            _db.Set<T>().Update(entity);
            _db.SaveChanges();
        }
        public bool AttachEntity(T entity)
        {
            try
            {
                _db.Set<T>().Attach(entity);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
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
