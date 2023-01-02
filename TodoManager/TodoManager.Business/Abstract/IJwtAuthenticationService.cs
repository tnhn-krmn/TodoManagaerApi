using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoManager.Entities.Concrete;

namespace TodoManager.Business.Abstract
{
    public interface IJwtAuthenticationService
    {
        User Authenticate(string username, string password);
    }
}
