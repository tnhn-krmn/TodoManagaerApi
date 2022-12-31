using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoManager.Entities.Concrete;

namespace TodoManager.Business.Abstract
{
    public interface ITodoService
    {
        List<Todo> GetAll();
        void Add(Todo todo);
        void Update(Todo todo);
        void Delete(int todoId);
        Todo GetById(int productId);
        Todo OneDayTodo();
        List<Todo> ThirtyDaysTodo();
        List<Todo> OneWeekTodo();

    }
}
