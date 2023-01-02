using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TodoManager.Business.Abstract;
using TodoManager.Entities.Concrete;

namespace TodoManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("OneWeekTodo")]
        public List<Todo> OneWeekTodo()
        {
           var todos =_todoService.OneWeekTodo();
           if(todos.Count > 0)
            {
                return todos;
            }
           else
            {
                return null;
            }
        }

        [HttpGet("OneMonthTodo")]
        public List<Todo> OneMonthTodo()
        {
            var todos = _todoService.ThirtyDaysTodo();
            if (todos.Count > 0)
            {
                return todos;
            }
            else
            {
                return null;
            }
        }

        [HttpGet("OneDayTodo")]
        public List<Todo> OneDayTodo()
        {
            var todos = _todoService.OneDayTodo();
            if (todos.Count > 0)
            {
                return todos;
            }
            else
            {
                return null;
            }
        }
    }
}
