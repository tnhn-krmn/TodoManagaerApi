using Newtonsoft.Json;
using System.Collections.Generic;
using TodoManager.Entities.Concrete;
using static ServiceStack.Svg;

namespace TodoManager.API.Extension
{
    public static class IsEmpty
    {
        public static List<Todo> IsTodo(List<Todo> todo)
        {
            if (todo.Count > 0)
            {
                return todo;
            }
            else
            {
                return null;
            }
        }
    }
}
