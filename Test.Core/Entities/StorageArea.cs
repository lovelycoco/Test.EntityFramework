using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 库区
    /// </summary>
    public class StorageArea : BaseEntityOfOperator
    {
        /// <summary>
        /// 库区编号
        /// </summary>
        public virtual string AreaCode { get; set; }
        /// <summary>
        /// 库区名称
        /// </summary>
        public virtual string AreaName { get; set; }
        /// <summary>
        /// 库区描述
        /// </summary>
        public virtual string AreaDescription { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public virtual bool IsEnabled { get; set; }
        /// <summary>
        /// 库位集合
        /// </summary>
        public virtual ICollection<StorageBin> StorageBins { get; }
        public StorageArea()
        {
            IsEnabled = true;
            StorageBins = new List<StorageBin>();
        }

    }

    /// <summary>
    /// 实体库区
    /// </summary>
    public class EntityStorageArea : StorageArea
    {
    }

    /// <summary>
    /// 虚拟库区
    /// </summary>
    public class VirtualStorageArea : StorageArea
    {
    }
}
