using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    public class StorageLocation : BaseEntityOfGuid
    {
        /// <summary>
        /// 库位编码
        /// </summary>
        public virtual string LocationCode { get; set; }
        /// <summary>
        /// 库位名称
        /// </summary>
        public virtual string LocationName { get; set; }
        /// <summary>
        /// 库位描述
        /// </summary>
        public virtual string Description { get; set; }
        /// <summary>
        /// 库位类型
        /// </summary>
        public virtual int LocationType { get; set; }
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
        /// 物料Id
        /// </summary>
        public virtual Guid MaterialId { get; set; }
        /// <summary>
        /// 物料信息
        /// </summary>
        public virtual Material Material { get; set; }
        /// <summary>
        /// 责任用户
        /// </summary>
        public virtual IList<UserStorageLocation> UserStorageLocations { get; set; }

        public StorageLocation()
        {
            IsEnabled = true;
            UserStorageLocations = new List<UserStorageLocation>();
        }
    }
}
