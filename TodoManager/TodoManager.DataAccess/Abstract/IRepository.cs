using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TodoManager.Core.Entities.Abstract;

namespace TodoManager.DataAccess.Abstract
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        List<T> GetList();

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
