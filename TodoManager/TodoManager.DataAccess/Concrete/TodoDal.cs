using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoManager.DataAccess.Abstract;
using TodoManager.Entities.Concrete;

namespace TodoManager.DataAccess.Concrete
{
    public class TodoDal : Repository<Todo,Context>,ITodoDal
    {
        public List<Todo> GetListOneWeekTodo()
        {

                DateTime date = DateTime.Now.Date.AddDays(7);
                var todo = GetDateMatch(date);
                return todo;
        }

        public List<Todo> GetListOneMonthTodo()
        {
                DateTime date = DateTime.Now.Date.AddDays(30);
                var todo = GetDateMatch(date);
                return todo;
        }

        public List<Todo> GetListOneDayTodo()
        {
                DateTime date = DateTime.Now.Date.AddHours(24);
                var todo = GetDateMatch(date);
                return todo;
        }

        private List<Todo> GetDateMatch(DateTime date)
        {
            using (var context = new Context())
            {
                var todo = context.Todos.Where(x => x.Date >= DateTime.Now.Date && x.Date < date.Date).ToList();
                return todo;
            }
        }
    }
}
