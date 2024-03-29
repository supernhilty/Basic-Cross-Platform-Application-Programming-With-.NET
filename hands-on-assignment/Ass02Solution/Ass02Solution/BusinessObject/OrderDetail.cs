﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{

    public class OrderDetail
    {
     
        public int OrderId { get; set; }
        [Required]   
        public int ProductId { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public float Discount { get; set; }

        public Order Order { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}
