using HospitalSystem.BLL.DesignPatterns.GenericRepository.IntRep;
using HospitalSystem.BLL.DesignPatterns.SingletonPattern;
using HospitalSystem.DAL.ContextClasses;
using HospitalSystem.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.BLL.DesignPatterns.GenericRepository.EFBaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        HospitalContext _db;
        protected BaseRepository()
        {
            _db=DBTool.DbInstance;
        }

        protected void Save()
        {
            _db.SaveChanges();
        }

        public void Add(T item)
        {
            _db.Set<T>().Add(item);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {
            item.DeletedDate = DateTime.Now;
            item.DataStatus = ENTITIES.Enums.DataStatus.Deleted;
            Save();
        }

        public void Destroy(T item)
        {
            if(item.DataStatus != ENTITIES.Enums.DataStatus.Deleted) return;

           _db.Set<T>().Remove(item);
           Save();
        }

        public T Find(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {
            return Where(x=>x.DataStatus != ENTITIES.Enums.DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetFirstDatas(int count = 1)
        {
            return _db.Set<T>().OrderBy(x => x.CreatedDate).Take(count).ToList();
        }

        public List<T> GetLastDatas(int count = 1)
        {
            return _db.Set<T>().OrderByDescending(x => x.CreatedDate).Take(count).ToList();
        }

        public List<T> GetModifieds()
        {
            return Where(x => x.DataStatus == ENTITIES.Enums.DataStatus.Modified);
        }

        public List<T> GetPassives()
        {
            return Where(x => x.DataStatus == ENTITIES.Enums.DataStatus.Deleted);
        }

        public object Select(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Select(exp);
        }

        public List<X> Select<X>(Expression<Func<T, X>> exp) where X : class
        {
            return _db.Set<T>().Select(exp).ToList();
        }

        public void Update(T item)
        {
            item.ModifiedDate = DateTime.Now;
            item.DataStatus = ENTITIES.Enums.DataStatus.Modified;
            T originalData = Find(item.ID);

            _db.Entry(originalData).CurrentValues.SetValues(item);
            Save();
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Where(exp).ToList();
        }
    }
}
