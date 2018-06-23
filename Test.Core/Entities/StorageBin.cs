using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 库位信息
    /// </summary>
    public class StorageBin : BaseEntityOfOperator
    {
        /// <summary>
        /// 库位编码
        /// </summary>
        public virtual string BinCode { get; set; }
        /// <summary>
        /// 库位名称
        /// </summary>
        public virtual string BinName { get; set; }
        /// <summary>
        /// 库位描述
        /// </summary>
        public virtual string BinDescription { get; set; }
        /// <summary>
        /// 是否使用
        /// </summary>
        public virtual bool IsEnabled { get; set; }
        /// <summary>
        /// 库区Id
        /// </summary>
        public virtual Guid StorageAreaId { get; set; }
        /// <summary>
        /// 库区信息
        /// </summary>
        public virtual StorageArea StorageArea { get; set; }
        /// <summary>
        /// 物料信息
        /// </summary>
        public virtual Material Material { get; set; }
        /// <summary>
        /// 责任用户
        /// </summary>
        public virtual ICollection<UserStorageBin> UserStorageBins { get;}

        public StorageBin()
        {
            IsEnabled = true;
            UserStorageBins = new List<UserStorageBin>();
        }
    }
    /// <summary>
    /// 实体库位
    /// </summary>
    public class EntityStorageBin : StorageBin
    {
    }
    /// <summary>
    /// 虚拟库位
    /// </summary>
    public class VirtualStorageBin : StorageBin
    {
    }
}
