using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 模板信息
    /// </summary>
    public class PickupTemplate : BaseEntityOfOperator
    {
        /// <summary>
        /// 模板名称
        /// </summary>
        public virtual string TemplateName { get; set; }
        /// <summary>
        /// 字典信息Id
        /// </summary>
        public virtual Guid DataDictionaryInfoId { get; set; }
        /// <summary>
        /// 模板类型
        /// </summary>
        public virtual DataDictionaryInfo TemplateType { get; set; }
        /// <summary>
        /// 模板记录
        /// </summary>
        public virtual ICollection<TemplateList> TemplateLists { get; }
        public PickupTemplate()
        {
            TemplateLists = new List<TemplateList>();
        }
    }
}
