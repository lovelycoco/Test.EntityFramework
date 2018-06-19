using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities.Test;

namespace Test.Core.Entities
{
    public class Student : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual Guid CourseId { get; set; }
        public virtual Course Course { get; set; }
        public Student()
        {
            base.Id = Guid.NewGuid();
        }
    }
}
