using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities.Test
{
    public class RolePermission : BaseEntity<Guid>
    {
        public virtual Role Role { get; set; }
        public virtual Permission Permission { get; set; }
        public RolePermission()
        {
            base.Id = Guid.NewGuid();
        }
    }
}
