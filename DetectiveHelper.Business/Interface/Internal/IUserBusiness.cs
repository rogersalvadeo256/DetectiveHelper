using DetectiveHelper.Business.Interface.Base;
using DetectiveHelper.Dto.Internal;
using DetectiveHelper.Repository.Interface.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveHelper.Business.Interface.Internal
{
    public interface IUserBusiness : IBaseBusiness<IUserRepository>
    {

        Task<List<UserDto>> GetAllUsers();


    }
}
