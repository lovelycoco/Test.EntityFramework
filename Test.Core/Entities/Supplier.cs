﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    public class Supplier : BaseEntityOfOperator
    {
        /// <summary>
        /// 供应商名称
        /// </summary>
        public virtual string SupplierName { get; set; }
        /// <summary>
        /// 供应商编号
        /// </summary>
        public virtual string SupplierCode { get; set; }
        /// <summary>
        /// 物料集合
        /// </summary>
        public virtual IList<Material> Materials { get; set; }
        public Supplier()
        {
            Materials = new List<Material>();
        }
    }
}
