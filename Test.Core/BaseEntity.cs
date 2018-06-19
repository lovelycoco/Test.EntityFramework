using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 抽象基类
    /// </summary>
    /// <typeparam name="TPrimaryKey"></typeparam>
    public abstract class BaseEntity<TPrimaryKey>
    {
        /// <summary>
        /// 主键
        /// </summary>
        public virtual TPrimaryKey Id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreatedTime { get; private set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public virtual DateTime ModifiedTime { get; set; }
        /// <summary>
        /// 是否已删除
        /// </summary>
        public virtual bool IsDeleted { get; set; }
        public BaseEntity()
        {
            CreatedTime = DateTime.Now;
            ModifiedTime = DateTime.Now;
            IsDeleted = false;
        }
    }
}
