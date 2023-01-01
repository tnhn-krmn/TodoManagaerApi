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
            using (var context = new Context())
            {
                DateTime weekEndDate = DateTime.Now.Date.AddDays(7);
                var todo = context.Todos.
                    Where(x => x.Date >= DateTime.Now.Date && x.Date < weekEndDate.Date).ToList();
                return todo;
            }
        }

        public List<Todo> GetListOneMonthTodo()
        {
            using (var context = new Context())
            {
                DateTime weekEndDate = DateTime.Now.Date.AddDays(30);
                var todo = context.Todos.
                    Where(x => x.Date >= DateTime.Now.Date && x.Date < weekEndDate.Date).ToList();
                return todo;
            }
        }

        public List<Todo> GetListOneDayTodo()
        {
            using (var context = new Context())
            {
                DateTime weekEndDate = DateTime.Now.Date.AddHours(24);
                var todo = context.Todos.
                    Where(x => x.Date >= DateTime.Now.Date && x.Date < weekEndDate.Date).ToList();
                return todo;
            }
        }
    }
}
