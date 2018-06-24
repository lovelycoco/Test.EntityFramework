﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    public class Box : BaseEntityOfOperator
    {
        /// <summary>
        /// 器具编号
        /// </summary>
        public virtual string BoxNo { get; set; }
        /// <summary>
        /// 器具类型Id
        /// </summary>
        public virtual Guid TypeId { get; set; }
        /// <summary>
        /// 器具类型
        /// </summary>
        public virtual DataDictionaryInfo BoxType { get; set; }
        /// <summary>
        /// 是否使用
        /// </summary>
        public virtual bool IsEnabled { get; set; }
        /// <summary>
        /// 是否破损
        /// </summary>
        public virtual bool IsDamaged { get; set; }
        /// <summary>
        /// 物料记录
        /// </summary>
        public virtual MaterialList MaterialList { get; set; }
        public Box()
        {
            IsEnabled = true;
            IsDamaged = false;
        }
    }
}