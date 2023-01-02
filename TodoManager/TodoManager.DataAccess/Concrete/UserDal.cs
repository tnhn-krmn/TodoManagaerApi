using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TodoManager.DataAccess.Abstract;
using TodoManager.Entities.Concrete;

namespace TodoManager.DataAccess.Concrete
{
    public class UserDal : Repository<User, Context>, IUserDal
    {
      
    }
}
