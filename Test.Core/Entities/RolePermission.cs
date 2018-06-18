using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 角色权限关系表
    /// </summary>
    public class RolePermission : BaseEntityOfGuid
    {
        /// <summary>
        /// 角色Id
        /// </summary>
        public virtual Guid RoleId { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public virtual Role Role { get; set; }
        /// <summary>
        /// 权限Id
        /// </summary>
        public virtual Guid PermissionId { get; set; }
        /// <summary>
        /// 权限
        /// </summary>
        public virtual Permission Permission { get; set; }
        public RolePermission()
        {

        }
    }
}
