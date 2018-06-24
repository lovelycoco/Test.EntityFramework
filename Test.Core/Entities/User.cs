﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities.Test;

namespace Test.Core.Entities
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class User : BaseEntityOfOperator
    {
        /// <summary>
        /// 用户名称
        /// </summary>
        public virtual string UserName { get; set; }
        /// <summary>
        /// 显示名称
        /// </summary>
        public virtual string NormalizedUserName { get; set; }
        /// <summary>
        /// email
        /// </summary>
        public virtual string Email { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public virtual string Password { get; set; }
        /// <summary>
        /// 最后登录时间
        /// </summary>
        public virtual DateTime? LastLoginTime { get; set; }
        /// <summary>
        /// 最后登出时间
        /// </summary>
        public virtual DateTime? LastLogoutTime { get; set; }
        /// <summary>
        /// 用户与库位
        /// </summary>
        public virtual ICollection<UserStorageBin> UserStorageBins { get; }
        /// <summary>
        /// 用户与角色
        /// </summary>
        public virtual ICollection<UserRole> UserRoles { get; }

        public User()
        {
            UserStorageBins = new List<UserStorageBin>();
            UserRoles = new List<UserRole>();
        }
    }
}
