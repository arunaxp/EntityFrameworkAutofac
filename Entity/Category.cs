using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Category : BaseEntity<int>
    {
        public virtual string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
