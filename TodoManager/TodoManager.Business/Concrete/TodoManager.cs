using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoManager.Business.Abstract;
using TodoManager.DataAccess.Abstract;
using TodoManager.Entities.Concrete;

namespace TodoManager.Business.Concrete
{
    public class TodoManager : ITodoService
    {
        ITodoDal _todoDal;

        public TodoManager(ITodoDal todoDal)
        {
            _todoDal = todoDal;
        }

        public void Add(Todo todo)
        {
            _todoDal.Add(todo);
        }

        public void Delete(int todoId)
        {
            _todoDal.Delete(new Todo { TodoId = todoId });
        }

        public List<Todo> GetAll()
        {
            return _todoDal.GetList();
        }

        public Todo GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public Todo OneDayTodo()
        {
            throw new NotImplementedException();
        }

        public List<Todo> OneWeekTodo()
        {
            throw new NotImplementedException();
        }

        public List<Todo> ThirtyDaysTodo()
        {
            throw new NotImplementedException();
        }

        public void Update(Todo todo)
        {
            _todoDal.Update(todo);
        }
    }
}
