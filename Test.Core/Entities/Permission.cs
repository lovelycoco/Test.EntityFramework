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
    public class Permission : BaseEntityOfGuid
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

        public Permission()
        {
            
        }
    }
}
