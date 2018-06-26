using System;
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
        /// 登录名称
        /// </summary>
        public virtual string LoginName { get; set; }
        /// <summary>
        /// 显示名称
        /// </summary>
        public virtual string UserName { get; set; }
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
        /// 是否启用
        /// </summary>
        public virtual bool IsEnabled { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public virtual int Age { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public virtual string PhoneNumber { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public virtual int Sex { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public virtual byte[] HeadPortrait { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public virtual string IDCard { get; set; }
        /// <summary>
        /// 入职时间
        /// </summary>
        public virtual DateTime? HireDate { get; set; }
        /// <summary>
        /// 是否离职
        /// </summary>
        public virtual bool IsQuited { get; set; }
        /// <summary>
        /// 离职时间
        /// </summary>
        public virtual DateTime? QuitDate { get; set; }
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
            IsEnabled = true;
            IsQuited = false;
        }
    }
}
