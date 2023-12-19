using DetectiveHelper.Model.Internal;
using DetectiveHelper.Repository.DbContexts;
using DetectiveHelper.Repository.Interface.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveHelper.Repository.Rules.Internal
{
    public class UserRepository : BaseRepository<UserModel>, IUserRepository
    {
        public UserRepository(DetectiveDbContext dbContext) : base(dbContext)
        {
                
        }
    }
}
