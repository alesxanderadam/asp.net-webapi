﻿using Altic_Shaw_Net6_Api.Entities;

namespace Altic_Shaw_Net6_Api.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }

        
        public string? UnitBrief { get; set; }

       
        public double UnitPrice { get; set; }

        public string? Image { get; set; }

        public DateTime ProductDate { get; set; }

        public bool? Available { get; set; }

        public string? Description { get; set; }
       
        public int CategoryId { get; set; }

        public string? SupplierId { get; set; }

        public int Quantity { get; set; }

        public double Discount { get; set; }

        public bool Special { get; set; }

        public bool Latest { get; set; }

        public int Views { get; set; }

        public virtual Category? Category { get; set; }

        public virtual ICollection<OrderDetail>? OrderDetails { get; set; } = new List<OrderDetail>();

        public virtual Supplier Supplier { get; set; } = null!;
    }
}
