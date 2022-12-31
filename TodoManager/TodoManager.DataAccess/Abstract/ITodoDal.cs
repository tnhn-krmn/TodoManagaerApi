using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoManager.Entities.Concrete;

namespace TodoManager.DataAccess.Abstract
{
    public interface ITodoDal : IRepository<Todo>
    {
    }
}
