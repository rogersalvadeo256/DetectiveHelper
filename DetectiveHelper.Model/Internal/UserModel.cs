using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveHelper.Model.Internal
{
    [Table("TB_USER")]
    public class UserModel
    {
        [Column("ID_USER")]
        public int Id { get; set; }
        [Column("DS_USER")]
        public string UserName { get; set; }
        [Column("DS_EMAIL")]
        public string Email { get; set; }
        [Column("PERFIL")]
        public int? Perfil { get; set; }
        [Column("FL_ATIVO")]
        public bool IsActive { get; set; }
        [Column("DS_SENHA_HASH")]
        public string PasswordHash { get; set; }
    }

}
