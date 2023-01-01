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
    public class TodosManager : ITodoService
    {
        ITodoDal _todoDal;

        public TodosManager(ITodoDal todoDal)
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

        public List<Todo> OneDayTodo()
        {
            return _todoDal.GetListOneDayTodo();
        }

        public List<Todo> OneWeekTodo()
        {
            return _todoDal.GetListOneWeekTodo();
        }

        public List<Todo> ThirtyDaysTodo()
        {
            return _todoDal.GetListOneMonthTodo();
        }

        public void Update(Todo todo)
        {
            _todoDal.Update(todo);
        }
    }
}
