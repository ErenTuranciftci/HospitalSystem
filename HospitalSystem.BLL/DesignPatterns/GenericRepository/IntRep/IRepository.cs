using HospitalSystem.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.BLL.DesignPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T: BaseEntity
    {
        // List Commands
        List<T> GetAll();
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetModifieds();

        // Modify Commands
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        void Destroy(T item);

        // Linq Commands
        List <T> Where (Expression<Func<T, bool>> exp);
        bool Any (Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        object Select (Expression<Func<T, bool>> exp);
        List<X> Select <X>(Expression<Func<T,X>> exp) where X : class;

        // Find 
        T Find (int id);
        List<T> GetLastDatas(int count =1);
        List<T> GetFirstDatas(int conunt = 1);

    }
}
