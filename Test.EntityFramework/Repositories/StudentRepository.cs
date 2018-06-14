using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities;
using Test.Core.IRepository;

namespace Test.EntityFramework.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        public bool Add(Student t)
        {
            using (TestDbContext db = new TestDbContext())
            {
                db.Students.Add(t);
                if (db.SaveChanges()>0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
