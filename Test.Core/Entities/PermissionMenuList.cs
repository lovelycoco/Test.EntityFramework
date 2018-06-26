using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    public class PermissionMenuList : BaseEntityOfOperator
    {
        /// <summary>
        /// 权限Id
        /// </summary>
        public virtual Guid PermissionId { get; set; }
        /// <summary>
        /// 权限信息
        /// </summary>
        public virtual Permission Permission { get; set; }
        /// <summary>
        /// 菜单Id
        /// </summary>
        public virtual Guid MenuListId { get; set; }
        /// <summary>
        /// 菜单信息
        /// </summary>
        public virtual MenuList MenuList { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public virtual bool IsEnabled { get; set; }
        public PermissionMenuList()
        {
            IsEnabled = true;
        }
    }
}
