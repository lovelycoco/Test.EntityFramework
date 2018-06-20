using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 责任人与库位关系
    /// </summary>
    public class UserStorageBin:BaseEntityOfGuid
    {
        /// <summary>
        /// 责任人Id
        /// </summary>
        public virtual Guid UserId { get; set; }
        /// <summary>
        /// 责任人
        /// </summary>
        public virtual User User { get; set; }
        /// <summary>
        /// 库位Id
        /// </summary>
        public virtual Guid StorageBinId { get; set; }
        /// <summary>
        /// 库位
        /// </summary>
        public virtual StorageBin StorageBin { get; set; }
    }
}
