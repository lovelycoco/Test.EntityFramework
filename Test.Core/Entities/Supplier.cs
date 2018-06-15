using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    public class Supplier : BaseEntityOfGuid
    {
        public virtual string SupplierName { get; set; }
        public virtual string SupplierCode { get; set; }
        public Supplier()
        {

        }
    }
}
