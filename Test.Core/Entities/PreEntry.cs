﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 预入库表
    /// </summary>
    public class PreEntry : BaseEntityOfOperator
    {
        /// <summary>
        /// 物料信息
        /// </summary>
        public virtual Material Material { get; set; }
        /// <summary>
        /// 总数量
        /// </summary>
        public virtual int TotalQuantity { get; set; }
    }
}
