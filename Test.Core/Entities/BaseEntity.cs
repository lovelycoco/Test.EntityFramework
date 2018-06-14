using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    public abstract class BaseEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
        public virtual DateTime CreatedTime { get; private set; }
        public virtual DateTime ModifiedTime { get; set; }
        public virtual bool IsDelete { get; set; }
        public BaseEntity()
        {
            CreatedTime = DateTime.Now;
            ModifiedTime = DateTime.Now;
            IsDelete = false;
        }
    }
}
