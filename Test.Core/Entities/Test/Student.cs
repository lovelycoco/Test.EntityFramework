using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    public class Student : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student()
        {
            base.Id = Guid.NewGuid();
        }
    }
}
