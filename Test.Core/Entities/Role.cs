using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities.Test;

namespace Test.Core.Entities
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class Role : BaseEntityOfOperator
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        public virtual string RoleName { get; set; }
        /// <summary>
        /// 角色权限关系
        /// </summary>
        public virtual ICollection<RolePermission> RolePermissions { get; }
        public virtual ICollection<UserRole> UserRoles { get; }
        public Role()
        {
            RolePermissions = new List<RolePermission>();
            UserRoles = new List<UserRole>();
        }
    }
}
