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
    public class StorageArea : BaseEntityOfGuid
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
        /// 库区类型
        /// </summary>
        public virtual int AreaType { get; set; }
        /// <summary>
        /// 库区描述
        /// </summary>
        public virtual string Description { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public virtual bool IsEnabled { get; set; }
        /// <summary>
        /// 库位集合
        /// </summary>
        public virtual IList<StorageLocation> StorageLocations { get;  set; }
        public StorageArea()
        {
            IsEnabled = true;
            StorageLocations = new List<StorageLocation>();
        }

    }
}
