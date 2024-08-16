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
        public void add(T item)
        {
            throw new NotImplementedException();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public T Find(int id)
        {
            throw new NotImplementedException();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public List<T> GetActiceve()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<T> GetFirstDatas(int conunt = 1)
        {
            throw new NotImplementedException();
        }

        public List<T> GetLastDatas(int count = 1)
        {
            throw new NotImplementedException();
        }

        public List<T> GetModifieds()
        {
            throw new NotImplementedException();
        }

        public List<T> GetPassives()
        {
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public object Select(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public List<X> Select<X>(Expression<Func<T, X>> exp) where X : class
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }

        public List<T> where(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }
    }
}
