using DetectiveHelper.Business.Interface.Internal;
using DetectiveHelper.Business.Rules.Internal;
using DetectiveHelper.Dto.Internal;
using DetectiveHelper.Facade.Interface.Internal;
using DetectiveHelper.Facade.Rules.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveHelper.Facade.Rules.Internal
{
    public class UserFacade : BaseFacade<IUserBusiness>, IUserFacade
    {
        private readonly IUserBusiness _userBusiness;

        public UserFacade(IUserBusiness userBusiness) : base(userBusiness) 
        {
            _userBusiness = userBusiness;
        }

        public Task<List<UserDto>> GetAllUsers()
        {
            return _userBusiness.GetAllUsers();
        }
    }
}
