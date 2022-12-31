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
    }
}
