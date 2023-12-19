using DetectiveHelper.Business.Interface.Internal;
using DetectiveHelper.Dto.Internal;
using DetectiveHelper.Facade.Interface.Base;
using DetectiveHelper.Facade.Rules.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveHelper.Facade.Interface.Internal
{
    public interface IUserFacade : IBaseFacade<IUserBusiness>
    {
        Task<List<UserDto>> GetAllUsers();
    }
}
