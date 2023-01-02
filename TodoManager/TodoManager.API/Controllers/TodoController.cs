using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TodoManager.API.Extension;
using TodoManager.Business.Abstract;
using TodoManager.Entities.Concrete;

namespace TodoManager.API.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpPost("OneWeekTodo")]
        public List<Todo> OneWeekTodo()
        {
           var todos =_todoService.OneWeekTodo();
            var todo = IsEmpty.IsTodo(todos);
            return todo;
        }

        [HttpPost("OneMonthTodo")]
        public List<Todo> OneMonthTodo()
        {
            var todos = _todoService.ThirtyDaysTodo();
            var todo = IsEmpty.IsTodo(todos);
            return todo;
        }

        [HttpPost("OneDayTodo")]
        public List<Todo> OneDayTodo()
        {
            var todos = _todoService.OneDayTodo();
            var todo = IsEmpty.IsTodo(todos);
            return todo;
        }
    }
}
