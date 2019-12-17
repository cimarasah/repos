using Cimarasah.DAL.Interface.Entities;
using Cimarasah.DAL.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Cimarasah.DAL.Interface.UnitOfWork
{
    public interface IUnitOfWork<T> where T : BaseEntity 
    {
        int Save(T model);
        int Update(T model);
        void Delete(T model);
        IEnumerable<T> GetAll();
        T GetById(object id);
        IEnumerable<T> Where(Expression<Func<T, bool>> expression);
        IEnumerable<T> OrderBy(Expression<Func<T, bool>> expression);
    }
}
