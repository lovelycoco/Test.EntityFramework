using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities.Test
{
    public class Course : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int MyProperty { get; set; }
        public virtual Guid StudentId { get; set; }
        public virtual Student Student { get; set; }
        public Course()
        {
            base.Id = Guid.NewGuid();
        }
    }
}
