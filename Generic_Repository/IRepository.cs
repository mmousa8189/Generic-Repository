using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Generic_Repository
{
    public interface IRepository<T> where T : EntityBase
{
    T GetById(int id);
    IEnumerable<T> EnumerableList();
    IEnumerable<T> EnumerableList(Expression<Func<T, bool>> predicate);
    IQueryable<T> QueryableList();
    IQueryable<T> QueryableList(Expression<Func<T, bool>> predicate);
    void Add(T entity);
    void Delete(T entity);
    void Edit(T entity);
}
}