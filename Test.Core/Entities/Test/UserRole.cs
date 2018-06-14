using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities.Test
{
    public class UserRole : BaseEntity<Guid>
    {
        public virtual Guid UserId { get; set; }
        public virtual Role Role { get; set; }
        public UserRole()
        {
            base.Id = Guid.NewGuid();
        }
    }
}
