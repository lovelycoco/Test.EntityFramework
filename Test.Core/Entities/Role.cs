using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public virtual IList<RolePermission> RolePermissions { get; private set; }
        public Role()
        {
            RolePermissions = new List<RolePermission>();
        }
    }
}
