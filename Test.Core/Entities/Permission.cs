using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 权限信息
    /// </summary>
    public class Permission : BaseEntityOfOperator
    {
        /// <summary>
        /// 权限名称
        /// </summary>
        public virtual string PermissionName { get; set; }
        /// <summary>
        /// 功能名称
        /// </summary>
        public virtual string FeatureName { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public virtual string Description { get; set; }
        /// <summary>
        /// 角色权限关系
        /// </summary>
        public virtual ICollection<RolePermission> RolePermissions { get; }
        /// <summary>
        /// 权限菜单关系
        /// </summary>
        public virtual ICollection<PermissionMenuList> PermissionMenuLists { get; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public virtual bool IsEnabled { get; set; }

        public Permission()
        {
            RolePermissions = new List<RolePermission>();
            PermissionMenuLists = new List<PermissionMenuList>();
        }
    }
}
