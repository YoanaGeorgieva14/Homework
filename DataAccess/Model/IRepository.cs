using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model
{
    internal interface IRepository<T> where T : EntityBase 
    {
        T GetById(int id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
    public abstract class EntityBase
    {
        public int Id { get; set; }
    }
}
