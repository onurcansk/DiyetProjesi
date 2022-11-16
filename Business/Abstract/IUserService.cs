using Entities.Dtos.Users;
using Entities.Enums;
using Entities.VMs.UserVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Register(UserCreateDTO user);
        UserClaims Login(UserLoginDTO user);
        List<UserVm> GetAll();
        UserVm Get(string id);

    }

}
