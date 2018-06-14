using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    public class User : BaseEntity<Guid>
    {
        public virtual string UserName { get; set; }
        public virtual string NormalizedUserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual DateTime? LastLoginTime { get; set; }
        public virtual DateTime? LastLogoutTime { get; set; }

        public User()
        {
            base.Id = Guid.NewGuid();
        }
    }
}
