using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveHelper.Dto.Internal
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int? Perfil { get; set; }
        public bool IsActive { get; set; }
        public string PasswordHash { get; set; }
    }

}
