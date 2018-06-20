using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core
{
    public class BaseEntityOfGuid:BaseEntity<Guid> 
    {
        public BaseEntityOfGuid()
        {
            base.Id = Guid.NewGuid();
        }
    }
}
