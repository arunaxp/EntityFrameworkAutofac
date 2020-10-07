using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Product : BaseEntity<Int64>
    {
        public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual string Name { get; set; }
        public virtual int MinimumStockLevel { get; set; }

    }
}
