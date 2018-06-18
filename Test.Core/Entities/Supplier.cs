using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    public class Supplier : BaseEntityOfGuid
    {
        /// <summary>
        /// 供应商名称
        /// </summary>
        public virtual string SupplierName { get; set; }
        /// <summary>
        /// 供应商编号
        /// </summary>
        public virtual string SupplierCode { get; set; }
        public Supplier()
        {

        }
    }
}
