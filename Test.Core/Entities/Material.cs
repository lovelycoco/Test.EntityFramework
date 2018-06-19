using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    public class Material : BaseEntityOfGuid
    {
        /// <summary>
        /// 物料编码
        /// </summary>
        public virtual string MaterialCode { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        public virtual string MaterialName { get; set; }
        /// <summary>
        /// 收容数量
        /// </summary>
        public virtual int PackageNumber { get; set; }
        /// <summary>
        /// 高储
        /// </summary>
        public virtual int HighStorage { get; set; }
        /// <summary>
        /// 低储
        /// </summary>
        public virtual int LowStorage { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public virtual bool IsEnabled { get; set; }
        /// <summary>
        /// 优先级
        /// </summary>
        public virtual int PriorityLevel { get; set; }
        /// <summary>
        /// 供应商Id
        /// </summary>
        public virtual Guid SupplierId { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        public virtual Supplier Supplier { get; set; }
        /// <summary>
        /// 库位信息
        /// </summary>
        public virtual StorageLocation StorageLocation { get; set; }

        public Material()
        {
            IsEnabled = true;
            HighStorage = 0;
            LowStorage = 0;
            PackageNumber = 0;
            PriorityLevel = 0;
        }

    }
}
