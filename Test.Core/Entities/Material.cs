﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 物料信息
    /// </summary>
    public class Material : BaseEntityOfOperator
    {
        /// <summary>
        /// 物料编码
        /// </summary>
        public virtual string MaterialNo { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        public virtual string MaterialName { get; set; }
        /// <summary>
        /// 收容数量
        /// </summary>
        public virtual int PackageQuantity { get; set; }
        /// <summary>
        /// 高储
        /// </summary>
        public virtual int Max { get; set; }
        /// <summary>
        /// 低储
        /// </summary>
        public virtual int Min { get; set; }
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
        public virtual StorageBin StorageBin { get; set; }
        /// <summary>
        /// 物料类型Id
        /// </summary>
        public virtual Guid MaterialTypeId { get; set; }
        /// <summary>
        /// 物料类型
        /// </summary>
        public virtual DataDictionaryInfo MaterialType { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public virtual decimal UnitPrice { get; set; }
        /// <summary>
        /// 物料记录
        /// </summary>
        public virtual ICollection<MaterialList> MaterialLists { get; }
        /// <summary>
        /// 备货记录表
        /// </summary>
        public virtual ICollection<PickupList> PickupLists { get; }
        /// <summary>
        /// 看板记录
        /// </summary>
        public virtual ICollection<NoteList> NoteLists { get; }
        /// <summary>
        /// 模板记录
        /// </summary>
        public virtual ICollection<TemplateList> TemplateLists { get; }
        /// <summary>
        /// 预入库
        /// </summary>
        public virtual PreEntry PreEntry { get; set; }
        /// <summary>
        /// 不良品
        /// </summary>
        public virtual ICollection<BadGoods> BadGoods { get; }
        /// <summary>
        /// 自提记录
        /// </summary>
        public virtual ICollection<SelfPickupList> SelfPickupLists { get; }
        /// <summary>
        /// 库存信息
        /// </summary>
        public virtual ICollection<Stock> Stocks { get; }
        /// <summary>
        /// 账目信息
        /// </summary>
        public virtual ICollection<Accounts> Accounts { get; }
        public Material()
        {
            IsEnabled = true;
            Max = 0;
            Min = 0;
            PackageQuantity = 0;
            PriorityLevel = 0;
            MaterialLists = new List<MaterialList>();
            PickupLists = new List<PickupList>();
            NoteLists = new List<NoteList>();
            TemplateLists = new List<TemplateList>();
            BadGoods = new List<BadGoods>();
            SelfPickupLists = new List<SelfPickupList>();
            Stocks = new List<Stock>();
            Accounts = new List<Accounts>();
        }

    }
}
