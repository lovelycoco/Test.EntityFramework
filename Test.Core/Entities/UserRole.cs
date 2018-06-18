using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities.Test
{
    /// <summary>
    /// 用户角色关系
    /// </summary>
    public class UserRole : BaseEntityOfGuid
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public virtual Guid UserId { get; set; }
        public virtual Guid RoleId { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public virtual Role Role { get; set; }
        public UserRole()
        {

        }
    }
}
