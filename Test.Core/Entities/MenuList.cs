using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 菜单表
    /// </summary>
    public class MenuList : BaseEntityOfOperator
    {
        /// <summary>
        /// 菜单名称
        /// </summary>
        public virtual string MenuName { get; set; }
        /// <summary>
        /// 显示名称
        /// </summary>
        public virtual string DisplayName { get; set; }
        /// <summary>
        /// 菜单路径
        /// </summary>
        public virtual string MenuURL { get; set; }
        /// <summary>
        /// 菜单描述
        /// </summary>
        public virtual string MenuDescription { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public virtual byte[] MenuIcon { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public virtual bool IsEnabled { get; set; }
        /// <summary>
        /// 权限菜单关系
        /// </summary>
        public virtual ICollection<PermissionMenuList> PermissionMenuLists { get; }

        public MenuList()
        {
            IsEnabled = true;
            PermissionMenuLists = new List<PermissionMenuList>();
        }
    }
}
