using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ProductModel
    {
        public Int64 Id { get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
        public string Name { get; set; }
        public int MinimumStockLevel { get; set; }

    }
}