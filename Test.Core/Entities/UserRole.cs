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
    public class UserRole : BaseEntityOfOperator
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public virtual Guid UserId { get; set; }
        /// <summary>
        /// 用户信息
        /// </summary>
        public virtual User User { get; set; }
        /// <summary>
        /// 角色Id
        /// </summary>
        public virtual Guid RoleId { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public virtual Role Role { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public virtual bool IsEnabled { get; set; }
        public UserRole()
        {
            IsEnabled = true;
        }
    }
}
