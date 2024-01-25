using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [MaxLength(40)]
        public string ProductName { get; set; } = null!;
        [MaxLength(20)]
        public string Weight { get; set; } = null!;
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }
        [Required]
        public int UnitInStock { get; set; }

        
    }
}
