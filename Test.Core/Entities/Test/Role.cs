using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities.Test
{
    public class Role : BaseEntity<Guid>
    {
        public virtual string RoleName { get; set; }
        public virtual IList<RolePermission>  RolePermissions { get; set; }
        public Role()
        {
            base.Id = Guid.NewGuid();
            RolePermissions = new List<RolePermission>();
        }
    }
}
