using AutoMapper;
using DetectiveHelper.Business.Interface.Internal;
using DetectiveHelper.Business.Rules.Base;
using DetectiveHelper.Dto.Internal;
using DetectiveHelper.Repository.Interface.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveHelper.Business.Rules.Internal
{
    public class UserBusiness : BaseBusiness<IUserRepository>, IUserBusiness
    {
        private readonly IUserRepository _repository;
        private readonly IMapper         _mapper;

        public UserBusiness(IUserRepository repository,IMapper mapper) : base(repository) 
        {
            _repository=repository ;
            _mapper    = mapper;
        }

        public async Task<List<UserDto>> GetAllUsers()
        {
            var users = await _repository.GetAllAsync();
            return _mapper.Map<List<UserDto>>(users);
        }
    }
}
