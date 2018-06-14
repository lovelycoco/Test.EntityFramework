using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities.Test
{
    public class Permission : BaseEntity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string FeatureName { get; set; }
        public virtual string Description { get; set; }

        public Permission()
        {
            base.Id = Guid.NewGuid();
        }
    }
}
